//USING
using UnityEngine;
//USING
using System;
//USING
using System.Collections;
//USING
using System.Collections.Generic;
//USING

//CLASS Smartwords
public partial class Smartwords {
    ///METHOD Smartwords
    public Smartwords (  ) {
        ///METHOD_BODY_START Smartwords
        Smartword smartword = null;
        ///Id crow
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName crow Crow
        ///Description crow A Plains Indian tribe. The Crow were enemies of the Cheyenne and Lakota. Horse raids between the tribes were common.
        ///IsCollectable crow false
        ///Tags crow 
        ///AlertDescriptions crow 
        smartword = new Smartword();
        smartword.Id = "crow";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "Crow";
        smartword.Description = "A Plains Indian tribe. The Crow were enemies of the Cheyenne and Lakota. Horse raids between the tribes were common.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id wealth
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName wealth wealth
        ///Description wealth A measure of things of value. Indians valued horses greatly, in addition to buffalo hides and other goods.
        ///IsCollectable wealth false
        ///Tags wealth 
        ///AlertDescriptions wealth 
        smartword = new Smartword();
        smartword.Id = "wealth";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "wealth";
        smartword.Description = "A measure of things of value. Indians valued horses greatly, in addition to buffalo hides and other goods.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id beaver
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName beaver beaver
        ///Description beaver a large aquatic rodent that uses its sharp teeth for building dams and underwater lodges
        ///IsCollectable beaver false
        ///Tags beaver 
        ///AlertDescriptions beaver 
        smartword = new Smartword();
        smartword.Id = "beaver";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "beaver";
        smartword.Description = "a large aquatic rodent that uses its sharp teeth for building dams and underwater lodges";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id buffalo
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName buffalo buffalo
        ///Description buffalo North American bison, large cow-like mammals European settlers called by the wrong name
        ///IsCollectable buffalo true
        ///Tags buffalo 
        ///AlertDescriptions buffalo 
        smartword = new Smartword();
        smartword.Id = "buffalo";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "buffalo";
        smartword.Description = "North American bison, large cow-like mammals European settlers called by the wrong name";
        smartword.IsCollectable = true;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id surveyor
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName surveyor surveyor
        ///Description surveyor a person who gathers information about the land in order to plan for railroad construction
        ///IsCollectable surveyor false
        ///Tags surveyor 
        ///AlertDescriptions surveyor 
        smartword = new Smartword();
        smartword.Id = "surveyor";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "surveyor";
        smartword.Description = "a person who gathers information about the land in order to plan for railroad construction";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id coup
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName coup coup
        ///Description coup Touching the enemy during battle, usually with a special stick (a coup stick). It was considered an act of bravery.
        ///IsCollectable coup false
        ///Tags coup 
        ///AlertDescriptions coup 
        smartword = new Smartword();
        smartword.Id = "coup";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "coup";
        smartword.Description = "Touching the enemy during battle, usually with a special stick (a coup stick). It was considered an act of bravery.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id courting
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName courting courting
        ///Description courting Trying to gain the love or affection of another person, especially one you want to marry.
        ///IsCollectable courting false
        ///Tags courting 
        ///AlertDescriptions courting 
        smartword = new Smartword();
        smartword.Id = "courting";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "courting";
        smartword.Description = "Trying to gain the love or affection of another person, especially one you want to marry.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id creator
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName creator Creator
        ///Description creator A god or spirit who created the earth and all its inhabitants.
        ///IsCollectable creator false
        ///Tags creator 
        ///AlertDescriptions creator 
        smartword = new Smartword();
        smartword.Id = "creator";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "Creator";
        smartword.Description = "A god or spirit who created the earth and all its inhabitants.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id dog_soldiers
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName dog_soldiers Dog Soldiers
        ///Description dog_soldiers A Cheyenne warrior society known for bravery in battle.
        ///IsCollectable dog_soldiers false
        ///Tags dog_soldiers 
        ///AlertDescriptions dog_soldiers 
        smartword = new Smartword();
        smartword.Id = "dog_soldiers";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "Dog Soldiers";
        smartword.Description = "A Cheyenne warrior society known for bravery in battle.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id elk_soldiers
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName elk_soldiers Elk Soldiers
        ///Description elk_soldiers A Cheyenne warrior society, also known as the Elk Horn Scraper Society. Chief Little Wolf was an Elk Soldier.
        ///IsCollectable elk_soldiers false
        ///Tags elk_soldiers 
        ///AlertDescriptions elk_soldiers 
        smartword = new Smartword();
        smartword.Id = "elk_soldiers";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "Elk Soldiers";
        smartword.Description = "A Cheyenne warrior society, also known as the Elk Horn Scraper Society. Chief Little Wolf was an Elk Soldier.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id horses
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName horses horses
        ///Description horses The horses of the Plains Indians are smaller than other breeds, are very tough, require less food, and can survive difficult weather conditions.
        ///IsCollectable horses false
        ///Tags horses 
        ///AlertDescriptions horses 
        smartword = new Smartword();
        smartword.Id = "horses";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "horses";
        smartword.Description = "The horses of the Plains Indians are smaller than other breeds, are very tough, require less food, and can survive difficult weather conditions.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id lakota
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName lakota Lakota
        ///Description lakota A northern Plains Indians tribe also known as the Teton, or Western Sioux, who were allies of the Northern Cheyenne.
        ///IsCollectable lakota false
        ///Tags lakota 
        ///AlertDescriptions lakota 
        smartword = new Smartword();
        smartword.Id = "lakota";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "Lakota";
        smartword.Description = "A northern Plains Indians tribe also known as the Teton, or Western Sioux, who were allies of the Northern Cheyenne.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id moccasin
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName moccasin mocassin
        ///Description moccasin Soft but sturdy footwear made out of deerskin by Cheyenne women, and decorated with beads, fringe, porcupine quills, and other ornaments.
        ///IsCollectable moccasin false
        ///Tags moccasin 
        ///AlertDescriptions moccasin 
        smartword = new Smartword();
        smartword.Id = "moccasin";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "mocassin";
        smartword.Description = "Soft but sturdy footwear made out of deerskin by Cheyenne women, and decorated with beads, fringe, porcupine quills, and other ornaments.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id quiver
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName quiver quiver
        ///Description quiver a case for carrying arrows
        ///IsCollectable quiver false
        ///Tags quiver 
        ///AlertDescriptions quiver 
        smartword = new Smartword();
        smartword.Id = "quiver";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "quiver";
        smartword.Description = "a case for carrying arrows";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id southern_cheyenne
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName southern_cheyenne Southern Cheyenne
        ///Description southern_cheyenne A tribe related to the Northern Cheyenne that lives in the Southern Plains. The Cheyenne split into these two tribes in the 1830s.
        ///IsCollectable southern_cheyenne false
        ///Tags southern_cheyenne 
        ///AlertDescriptions southern_cheyenne 
        smartword = new Smartword();
        smartword.Id = "southern_cheyenne";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "Southern Cheyenne";
        smartword.Description = "A tribe related to the Northern Cheyenne that lives in the Southern Plains. The Cheyenne split into these two tribes in the 1830s.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id tipi
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName tipi tipi
        ///Description tipi A tent-like structure traditionally made from buffalo hides wrapped around wooden poles. Tipis are strong but portable.
        ///IsCollectable tipi false
        ///Tags tipi 
        ///AlertDescriptions tipi 
        smartword = new Smartword();
        smartword.Id = "tipi";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "tipi";
        smartword.Description = "A tent-like structure traditionally made from buffalo hides wrapped around wooden poles. Tipis are strong but portable.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id haahe
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName haahe haahe
        ///Description haahe A common way for Cheyenne men to greet one another, similar to hello.
        ///IsCollectable haahe false
        ///Tags haahe 
        ///AlertDescriptions haahe 
        smartword = new Smartword();
        smartword.Id = "haahe";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "haahe";
        smartword.Description = "A common way for Cheyenne men to greet one another, similar to hello.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id sign_language
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName sign_language sign language
        ///Description sign_language An elaborate set of hand signals used by Plains Indian tribes, who spoke a wide variety of languages, to communicate with one another.
        ///IsCollectable sign_language false
        ///Tags sign_language 
        ///AlertDescriptions sign_language 
        smartword = new Smartword();
        smartword.Id = "sign_language";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "sign language";
        smartword.Description = "An elaborate set of hand signals used by Plains Indian tribes, who spoke a wide variety of languages, to communicate with one another.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id negotiate
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName negotiate negotiate
        ///Description negotiate To deal or bargain with others when preparing a treaty, sale, or contract.
        ///IsCollectable negotiate false
        ///Tags negotiate 
        ///AlertDescriptions negotiate 
        smartword = new Smartword();
        smartword.Id = "negotiate";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "negotiate";
        smartword.Description = "To deal or bargain with others when preparing a treaty, sale, or contract.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id ironhorse
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName ironhorse ironhorse
        ///Description ironhorse A nineteenth-century term to describe a steam train.
        ///IsCollectable ironhorse false
        ///Tags ironhorse 
        ///AlertDescriptions ironhorse 
        smartword = new Smartword();
        smartword.Id = "ironhorse";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "ironhorse";
        smartword.Description = "A nineteenth-century term to describe a steam train.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id raid
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName raid raid
        ///Description raid To go into enemy territory for the purpose of taking valuables. Raids also provided warriors the opportunity to develop skills and count coup.
        ///IsCollectable raid true
        ///Tags raid 
        ///AlertDescriptions raid 
        smartword = new Smartword();
        smartword.Id = "raid";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "raid";
        smartword.Description = "To go into enemy territory for the purpose of taking valuables. Raids also provided warriors the opportunity to develop skills and count coup.";
        smartword.IsCollectable = true;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id war_shield
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName war_shield war shield
        ///Description war_shield A small decorated shield made of strong buffalo hide. Mostly used while on horseback, war shields could block arrows.
        ///IsCollectable war_shield false
        ///Tags war_shield 
        ///AlertDescriptions war_shield 
        smartword = new Smartword();
        smartword.Id = "war_shield";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "war shield";
        smartword.Description = "A small decorated shield made of strong buffalo hide. Mostly used while on horseback, war shields could block arrows.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id sun_dance
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName sun_dance Sun Dance
        ///Description sun_dance A sacred dance to celebrate life that Plains Indians tribes performed each summer. It was considered essential for tribal unity and cultural continuity.
        ///IsCollectable sun_dance false
        ///Tags sun_dance 
        ///AlertDescriptions sun_dance 
        smartword = new Smartword();
        smartword.Id = "sun_dance";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "Sun Dance";
        smartword.Description = "A sacred dance to celebrate life that Plains Indians tribes performed each summer. It was considered essential for tribal unity and cultural continuity.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id settlers
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName settlers settlers
        ///Description settlers People who established farms, communities, and towns in the West, including homesteaders who were given land by the government.
        ///IsCollectable settlers true
        ///Tags settlers 
        ///AlertDescriptions settlers 
        smartword = new Smartword();
        smartword.Id = "settlers";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "settlers";
        smartword.Description = "People who established farms, communities, and towns in the West, including homesteaders who were given land by the government.";
        smartword.IsCollectable = true;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id rations
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName rations rations
        ///Description rations Specific amounts of food the government provided to Indians to keep them on reservations and discourage them from hunting buffalo.
        ///IsCollectable rations true
        ///Tags rations 
        ///AlertDescriptions rations 
        smartword = new Smartword();
        smartword.Id = "rations";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "rations";
        smartword.Description = "Specific amounts of food the government provided to Indians to keep them on reservations and discourage them from hunting buffalo.";
        smartword.IsCollectable = true;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id annuity
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName annuity annuity
        ///Description annuity A yearly payment (usually cloth and supplies) the U.S. government gave to Indian tribes in exchange for signing treaties giving access to Indian lands.
        ///IsCollectable annuity false
        ///Tags annuity 
        ///AlertDescriptions annuity 
        smartword = new Smartword();
        smartword.Id = "annuity";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "annuity";
        smartword.Description = "A yearly payment (usually cloth and supplies) the U.S. government gave to Indian tribes in exchange for signing treaties giving access to Indian lands.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id scout
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName scout scout
        ///Description scout An individual sent to obtain information about an enemy. In 1866, the U.S. Army began to enlist Indians to serve as scouts.
        ///IsCollectable scout true
        ///Tags scout 
        ///AlertDescriptions scout 
        smartword = new Smartword();
        smartword.Id = "scout";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "scout";
        smartword.Description = "An individual sent to obtain information about an enemy. In 1866, the U.S. Army began to enlist Indians to serve as scouts.";
        smartword.IsCollectable = true;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id hostile
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName hostile hostile
        ///Description hostile Considered an enemy; openly opposed or resisting.
        ///IsCollectable hostile false
        ///Tags hostile 
        ///AlertDescriptions hostile 
        smartword = new Smartword();
        smartword.Id = "hostile";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "hostile";
        smartword.Description = "Considered an enemy; openly opposed or resisting.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id ricochet
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName ricochet ricochet
        ///Description ricochet A bullet or shot that bounces off a hard surface and then goes in a different direction.
        ///IsCollectable ricochet false
        ///Tags ricochet 
        ///AlertDescriptions ricochet 
        smartword = new Smartword();
        smartword.Id = "ricochet";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "ricochet";
        smartword.Description = "A bullet or shot that bounces off a hard surface and then goes in a different direction.";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id coulee
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName coulee coulee
        ///Description coulee a ravine or narrow valley between hills
        ///IsCollectable coulee false
        ///Tags coulee 
        ///AlertDescriptions coulee 
        smartword = new Smartword();
        smartword.Id = "coulee";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "coulee";
        smartword.Description = "a ravine or narrow valley between hills";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///Id keepsake
        ///SmallImagePath 
        ///LargeImagePath 
        ///DisplayName keepsake keepsake
        ///Description keepsake a small item kept in memory of the person who owned it
        ///IsCollectable keepsake false
        ///Tags keepsake 
        ///AlertDescriptions keepsake 
        smartword = new Smartword();
        smartword.Id = "keepsake";
        smartword.SmallImagePath = "";
        smartword.LargeImagePath = "";
        smartword.DisplayName = "keepsake";
        smartword.Description = "a small item kept in memory of the person who owned it";
        smartword.IsCollectable = false;
        smartword.Tags = new List<string>() {};
        smartword.AlertDescriptions = new List<string>() {""};
        AddSmartwordData(smartword);
        ///METHOD_BODY_END Smartwords
    }
}
//CLASS_END Smartwords
