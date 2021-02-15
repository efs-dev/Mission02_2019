using System.Collections.Generic;
using UnityEditor;
using Amazon.Polly;
using Amazon.Polly.Model;
using System.IO;
using UnityEngine;

namespace Muse.Editors.Utility
{

    public static class AmazonServices
    {

        public static void GenerateAudio(string path, List<AmazonAudioRequest> requests)
        {
            var validationCB = System.Net.ServicePointManager.ServerCertificateValidationCallback;
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => { return true; };

            var client = new AmazonPollyClient("AKIAJBQ47ON5OVOVCHQQ", "b/BngZp5MJ/X1iKXQhqQ2ydmP6AmMDI0NjeP7y7F", Amazon.RegionEndpoint.USEast1);

            var describeVoicesRequest = new DescribeVoicesRequest();
            var describeVoicesResult = client.DescribeVoices(describeVoicesRequest);
            var voices = describeVoicesResult.Voices;

            for (var i = 0; i < requests.Count; i++)
            {
                var request = requests[i];

                var requestPath = path + request.Id;

                var speechRequest = new SynthesizeSpeechRequest();
                speechRequest.Text = request.Text;
                speechRequest.VoiceId = voices[0].Id;
                speechRequest.OutputFormat = OutputFormat.Mp3;
                var speechUrl = client.SynthesizeSpeech(speechRequest);

                using (FileStream output = File.OpenWrite(requestPath + ".mp3"))
                {
                    CopyStream(speechUrl.AudioStream, output);
                }

                speechRequest = new SynthesizeSpeechRequest();
                speechRequest.Text = request.Text;
                speechRequest.VoiceId = voices[0].Id;
                speechRequest.OutputFormat = OutputFormat.Ogg_vorbis;
                speechUrl = client.SynthesizeSpeech(speechRequest);

                using (FileStream output = File.OpenWrite(requestPath + ".ogg"))
                {
                    CopyStream(speechUrl.AudioStream, output);
                }
            }

            System.Net.ServicePointManager.ServerCertificateValidationCallback = validationCB;
            AssetDatabase.Refresh();
        }

        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }
    }

    public class AmazonAudioRequest
    {
        public string Text;
        public string Id;
    }
}