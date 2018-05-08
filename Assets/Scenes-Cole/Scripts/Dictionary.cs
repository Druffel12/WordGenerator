using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour {

    //Array for word Dictionary
    public string[] WordBaseGeneral;
    public string[] WordBaseNames;
    public string[] WordBaseSexual;
    public string[] WordBaseReferences;
    void Start()
    {
        // total possible adds 60
        WordBaseGeneral = new string[]//22
        {
         "Shit", "Fuck", "Ass" , "Asshole", "Bitch",//5
         "Dickhead", "Dumbass", "Fuck Boi", "Fuckwit", "Fucknugget",//5
         "Mother Fucker", "Jackass","Suckass", "Lardass",//4
         "Shitcunt", "Shiznit", "Thundercunt",  "MAGA",//4
         "Wang-Chung", "No U", "Shizno", "Cockbite"//4
        };

        WordBaseNames = new string[]//10
        {
         "Dale", "Paul", "Zach", "Cole", "Terry",//5
         "Levi", "Mom", "Wyatt", "Knebel", "Kobey Deer"//5
        };

        WordBaseSexual = new string[]//9
        {
          "Va-j-j", "Skeet",  "Rimjob", "Skullfuck",//4
          "Dicks", "Penis", "Schlong", "Twat", "Fuck-Titty",//5
        };

        WordBaseReferences = new string[]//20
        {
            "Wubb-Lubba-Dub-Dub", "Han shot first",//2 
            "Wax on wax off", "I find your lack of faith disturbing.",//2
            "Do or do not, there is no try.", "He's dead, Jim!",//2
            "Oh my god they killed Kenny! You Bastards!", "Bring out your dead",//2
            "My name is Inigo Montoya. You killed my father. Prepare to die!",//1
            "These aren't the droids you're looking for.", "BOY!",//2
            "You maniacs! You blew it up! Oh, damn you! Damn you all to hell!",//1
            "ET phone home", "What... is the air-speed velocity of an unladen swallow?",//2
            "I'm sorry, Dave. I'm afraid I can't do that.",  "One ring to rule them all",//2
            "Now you're thinking with portals.", "REDROCKET", "REDRUM", "Praise the sun"//4 
        };
    }
}
