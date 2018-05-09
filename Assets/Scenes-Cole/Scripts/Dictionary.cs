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
        // total possible adds 205
        WordBaseGeneral = new string[]
        {
         "Shit", "Fuck", "Ass" , "Asshole", "Bitch", "Dipshit", "Douche Nozzle", "Douche Pickle", "Whore",
         "Dickhead", "Dumbass", "Fuck Boi", "Fuckwit", "Fucknugget", "Douchebag", "Cunt", "Shithead",
         "Mother Fucker", "Jackass","Suckass", "Lardass", "Dipass", "Cock sucker", "Cock", "Sister Fister",
         "Shitcunt", "Shiznit", "Thundercunt",  "MAGA", "Wanker", "Pisspot", "Twatwaffle", "Fuck-knuckle",
         "Wang-Chung", "No U", "Shizno", "Cockbite", "Cuck", "Loser", "Idiot", "Moron", "Gold-digger"
         
        };

        WordBaseNames = new string[]
        {
         "Dale", "Paul", "Zach", "Cole", "Terry", "Margaret Thatcher", "Hyland", "Michael", "Clayton",
         "Levi", "Mom", "Wyatt", "Knebel", "Kobey Deer", "Tucker", "Quinn", "Myhre", "Trump", "Jason",
         "Bentjen", "Druffel", "Gallagher", "Gibbons", "Hines", "Harley", "Hinkle", "Bryan", "Walker",
         "Kaplor", "Evan", "Miller", "Letko", "Mart mart", "Pearson", "Nguyen", "Kimberly", "Cee Jay",
         "MacFarlane", "Shea", "McAuley", "Oriel", "Rosenberg", "Caleb", "Seay", "Xander", "Thomas",
        };

        WordBaseSexual = new string[]
        {

          "Va-j-j", "Skeet",  "Rimjob", "Skullfuck", "Cucking", "Succubus", "Anal", "Anal Fissures", "Anal stretching",
          "Dicks", "Penis", "Schlong", "Twat", "Fuck Titty", "Dogging", "Cum slut", "Cum bucket", "Anal fisting", "Smut",
          "Cum Dumpster", "Smegma", "Queefing", "Semen", "Golden Shower", "Pee Tape", "Bukkake", "Futa", "Muff Diving",
          "Three way", "Four way", "Five way", "Orgy", "Strap-on", "Lewd", "Murloc Bulge", "Lube", "Penis pump", "BDSM",
          "Water BDSM", "Electric BDSM", "Foot porn", "Porn", "Foot Pussy", "Two Girls One Cup", "Scaley", "Furry", "Loli",
          "Hentai", "Tentai", "MILF", "GILF", "Virgin", "Cherry", "Choking", "Cream Pie", "Jailbait", "Climax", "Ejaculate",
          "Orgasm", "Role Play", "Foreplay", "Fingering", "Oral", "Handjob", "Blowjob", "Titjob", "Grinding", "Buttplug",
          "Masturbation", "Circle Jerk", "Cock Ring", "Cross The Streams", "Eiffel Tower", "Jedi Fight", "Cum Shot", "Intercrucial Sex",
          "Cowgirl", "Reverse Cowgirl", "Pegging", "69", "Missionary", "Amazonian", "Daddy", "Docking", "Butt Stuff", "Shocker",
          "Spocker", "Kinky", "Fetlang", "Pennywise", "Double Fisting", "Thanos' Dick", "Ear Fuck", "Karmasutra", "Menajahtwa"
        };

        WordBaseReferences = new string[]//21
        {
            "Wubb-Lubba-Dub-Dub", "Han shot first", "They're taking the hobbits to Isengard!",
            "Wax on wax off", "I find your lack of faith disturbing.",
            "Do or do not, there is no try.", "He's dead, Jim!", "Seven holes",
            "Oh my god they killed Kenny! You Bastards!", "Bring out your dead",
            "My name is Inigo Montoya. You killed my father. Prepare to die!",
            "These aren't the droids you're looking for.", "BOY!",
            "You maniacs! You blew it up! Oh, damn you! Damn you all to hell!",
            "ET phone home", "What... is the air-speed velocity of an unladen swallow?",
            "I'm sorry, Dave. I'm afraid I can't do that.",  "One ring to rule them all",
            "Now you're thinking with portals.", "Redrocket", "REDRUM", "Praise the sun"
        };
    }
}
