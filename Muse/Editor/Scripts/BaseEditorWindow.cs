using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;

namespace Muse.Editors
{
    public abstract class BaseMuseEditorWindow : EditorWindow
    {
        public virtual void ReloadScript()
        {
        }
    }

    public abstract class MuseEditorWindow<DerivedClassType, MementoType, PersistantDataType> : BaseMuseEditorWindow where DerivedClassType: MuseEditorWindow<DerivedClassType, MementoType, PersistantDataType> where MementoType : Memento where PersistantDataType : PersistantData<MementoType>
    {
        public PersistantDataType Data { get; private set; }

        private static Dictionary<string, MuseEditorWindow<DerivedClassType, MementoType, PersistantDataType>> _instances = new Dictionary<string, MuseEditorWindow<DerivedClassType, MementoType, PersistantDataType>>();
        
        public static DerivedClassType GetInstance()
        {
            Type t = typeof(DerivedClassType);
            
            if (!_instances.ContainsKey(t.Name))
                return null;

            return (DerivedClassType) _instances[t.Name];
        }

        public static void CreateWindow(string windowName)
        {
            var window = EditorWindow.GetWindow<DerivedClassType>();
            window.titleContent = new GUIContent(windowName);
            window.Show();

            window.Data = ScriptableObject.CreateInstance<PersistantDataType>();
            AssetDatabase.CreateAsset(window.Data, MuseEditor.EditorDataPath + windowName + ".asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            if (_instances.ContainsKey(typeof(DerivedClassType).Name))
                _instances.Remove(typeof(DerivedClassType).Name);
            _instances.Add(typeof(DerivedClassType).Name, window);

            window.OnInit();
        }

        protected abstract void OnInit();
            
        [SetupEditorDirectories]
        protected virtual void SetupEditorDirectories() { }

        protected abstract void OnSetupMementoStack();

        private void OnDestroy()
        {
            if (_instances.ContainsKey(GetType().Name))
                _instances.Remove(GetType().Name);
            OnDestroyed();
        }

        protected abstract void OnDestroyed();
        
        public sealed override void ReloadScript()
        {
            var windows = Resources.FindObjectsOfTypeAll(typeof(DerivedClassType)) as DerivedClassType[];
            if (windows.Length == 0)
                return;

            var window = windows[0];
            if (_instances.ContainsKey(window.GetType().Name))
                _instances.Remove(window.GetType().Name);
            _instances.Add(window.GetType().Name, window);

            OnReloadScript();
        }

        protected abstract void OnReloadScript();
        
        
    }

    [Serializable]
    public abstract class PersistantData<T> : ScriptableObject where T: Memento
    {
        public MementoStack<T> MementoStack { get; private set; }

        public PersistantData()
        {
            MementoStack = new MementoStack<T>();
            Init();
        }

        protected abstract void Init();
        public abstract PersistantData<T> Clone();
    }

    [Serializable]
    public class MementoStack<T> where T : Memento
    {
        [SerializeField]
        private List<T> _undo = new List<T>();
        [SerializeField]
        private List<T> _redo = new List<T>();

        public int UndoCount { get { return _undo.Count; } }
        public int RedoCount { get { return _redo.Count; } }

        public Action<T> Restore = (T) => { Debug.Log("default Restore"); };
        public Func<T> GetMementoData = () => { Debug.Log("default getmementodata"); return null; };
        public Action OnChange = () => { };

        public void Clear()
        {
            _undo.Clear();
            _redo.Clear();
        }

        public void CreateMemento()
        {
            _undo.Add(GetMementoData());
            _redo.Clear();

            OnChange();
        }

        public void Undo()
        {
            if (_undo.Count == 0)
                return;

            var memento = _undo[_undo.Count - 1];
            _undo.Remove(memento);

            _redo.Add(GetMementoData());

            Restore(memento);
            OnChange();
        }

        public void Redo()
        {
            if (_redo.Count == 0)
                return;

            var memento = _redo[_redo.Count - 1];
            _redo.Remove(memento);

            _undo.Add(GetMementoData());
            Restore(memento);
            OnChange();
        }
    }

    [Serializable]
    public abstract class Memento
    {

    }

    

    /*
    public class TestMemento : Memento
    {

    }

    public class TestPersistantData : PersistantData<TestMemento>
    {
        protected override void Init()
        {
        }

        public override PersistantData<TestMemento> Clone()
        {
            return null;
        }
    }

    public class TestEditor : MuseEditorWindow<TestEditor, TestMemento, TestPersistantData>
    {
        [MenuItem("Muse/Test")]
        public static void Init()
        {
            CreateWindow("Test");
        }

        public void Test() { }

        protected override void OnInit()
        {
        }

        protected override void OnReloadScript()
        {
            Debug.Log("reload test editor");
        }

        protected override void OnSetupMementoStack()
        {
        }

        protected override void OnDestroyed()
        {
        }
    }

    public class CowMemento : Memento
    {

    }

    public class CowPersistantData : PersistantData<CowMemento>
    {
        protected override void Init()
        {
        }

        public override PersistantData<CowMemento> Clone()
        {
            return null;
        }
    }

    public class CowEditor : MuseEditorWindow<CowEditor, CowMemento, CowPersistantData>
    {
        [MenuItem("Muse/Cow")]
        public static void Init()
        {
            CreateWindow("Cow");
        }

        protected override void OnInit()
        {
        }

        protected override void OnReloadScript()
        {
            Debug.Log("reload cow editor");
        }

        protected override void OnSetupMementoStack()
        {
        }

        protected override void OnDestroyed()
        {
        }
    }
    */
}
