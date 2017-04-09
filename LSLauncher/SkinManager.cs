using System.Collections.Generic;

namespace LSLauncher
{
    public static class SkinManager
    {
        public static Dictionary<string, Skins> Skins { get; private set; } = new Dictionary<string, Skins> {
                    { "Wukong", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Volcanic Wukong" }
                        ,new Skin() { Index = 2, Name = "General Wukong" }
                        ,new Skin() { Index = 3, Name = "Jade Dragon Wukong" }
                        ,new Skin() { Index = 4, Name = "Underworld Wukong" }
                        })}
                        ,{ "Jax", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "The Mighty Jax" }
                        ,new Skin() { Index = 2, Name = "Vandal Jax" }
                        ,new Skin() { Index = 3, Name = "Angler Jax" }
                        ,new Skin() { Index = 4, Name = "PAX Jax" }
                        ,new Skin() { Index = 5, Name = "Jaximus" }
                        ,new Skin() { Index = 6, Name = "Temple Jax" }
                        ,new Skin() { Index = 7, Name = "Nemesis Jax" }
                        ,new Skin() { Index = 8, Name = "SKT T1 Jax" }
                        })}
                        ,{ "Shaco", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Mad Hatter Shaco" }
                        ,new Skin() { Index = 2, Name = "Royal Shaco" }
                        ,new Skin() { Index = 3, Name = "Nutcracko" }
                        ,new Skin() { Index = 4, Name = "Workshop Shaco" }
                        ,new Skin() { Index = 5, Name = "Asylum Shaco" }
                        ,new Skin() { Index = 6, Name = "Masked Shaco" }
                        })}
                        ,{ "Warwick", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Grey Warwick" }
                        ,new Skin() { Index = 2, Name = "Urf the Manatee" }
                        ,new Skin() { Index = 3, Name = "Big Bad Warwick" }
                        ,new Skin() { Index = 4, Name = "Tundra Hunter Warwick" }
                        ,new Skin() { Index = 5, Name = "Feral Warwick" }
                        ,new Skin() { Index = 6, Name = "Firefang Warwick" }
                        ,new Skin() { Index = 7, Name = "Hyena Warwick" }
                        })}
                        ,{ "Nidalee", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Snow Bunny Nidalee" }
                        ,new Skin() { Index = 2, Name = "Leopard Nidalee" }
                        ,new Skin() { Index = 3, Name = "French Maid Nidalee" }
                        ,new Skin() { Index = 4, Name = "Pharaoh Nidalee" }
                        ,new Skin() { Index = 5, Name = "Bewitching Nidalee" }
                        ,new Skin() { Index = 6, Name = "Headhunter Nidalee" }
                        })}
                        ,{ "Zyra", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Wildfire Zyra" }
                        ,new Skin() { Index = 2, Name = "Haunted Zyra" }
                        ,new Skin() { Index = 3, Name = "SKT T1 Zyra" }
                        })}
                        ,{ "Brand", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Apocalyptic Brand" }
                        ,new Skin() { Index = 2, Name = "Vandal Brand" }
                        ,new Skin() { Index = 3, Name = "Cryocore Brand" }
                        ,new Skin() { Index = 4, Name = "Zombie Brand" }
                        })}
                        ,{ "Rammus", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "King Rammus" }
                        ,new Skin() { Index = 2, Name = "Chrome Rammus" }
                        ,new Skin() { Index = 3, Name = "Molten Rammus" }
                        ,new Skin() { Index = 4, Name = "Freljord Rammus" }
                        ,new Skin() { Index = 5, Name = "Ninja Rammus" }
                        ,new Skin() { Index = 6, Name = "Full Metal Rammus" }
                        })}
                        ,{ "Corki", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "UFO Corki" }
                        ,new Skin() { Index = 2, Name = "Ice Toboggan Corki" }
                        ,new Skin() { Index = 3, Name = "Red Baron Corki" }
                        ,new Skin() { Index = 4, Name = "Hot Rod Corki" }
                        ,new Skin() { Index = 5, Name = "Urfrider Corki" }
                        ,new Skin() { Index = 6, Name = "Dragonwing Corki" }
                        ,new Skin() { Index = 7, Name = "Fnatic Corki" }
                        })}
                        ,{ "Braum", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Dragonslayer Braum" }
                        })}
                        ,{ "Darius", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Lord Darius" }
                        ,new Skin() { Index = 2, Name = "Bioforge Darius" }
                        ,new Skin() { Index = 3, Name = "Woad King Darius" }
                        ,new Skin() { Index = 4, Name = "Dunkmaster Darius" }
                        })}
                        ,{ "Tryndamere", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Highland Tryndamere" }
                        ,new Skin() { Index = 2, Name = "King Tryndamere" }
                        ,new Skin() { Index = 3, Name = "Viking Tryndamere" }
                        ,new Skin() { Index = 4, Name = "Demonblade Tryndamere" }
                        ,new Skin() { Index = 5, Name = "Sultan Tryndamere" }
                        ,new Skin() { Index = 6, Name = "Warring Kingdoms Tryndamere" }
                        })}
                        ,{ "Miss Fortune", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Cowgirl Miss Fortune" }
                        ,new Skin() { Index = 2, Name = "Waterloo Miss Fortune" }
                        ,new Skin() { Index = 3, Name = "Secret Agent Miss Fortune" }
                        ,new Skin() { Index = 4, Name = "Candy Cane Miss Fortune" }
                        ,new Skin() { Index = 5, Name = "Road Warrior Miss Fortune" }
                        ,new Skin() { Index = 6, Name = "Mafia Miss Fortune" }
                        ,new Skin() { Index = 7, Name = "Arcade Miss Fortune" }
                        })}
                        ,{ "Yorick", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Undertaker Yorick" }
                        ,new Skin() { Index = 2, Name = "Pentakill Yorick" }
                        })}
                        ,{ "Xerath", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Runeborn Xerath" }
                        ,new Skin() { Index = 2, Name = "Battlecast Xerath" }
                        ,new Skin() { Index = 3, Name = "Scorched Earth Xerath" }
                        })}
                        ,{ "Sivir", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Warrior Princess Sivir" }
                        ,new Skin() { Index = 2, Name = "Spectacular Sivir" }
                        ,new Skin() { Index = 3, Name = "Huntress Sivir" }
                        ,new Skin() { Index = 4, Name = "Bandit Sivir" }
                        ,new Skin() { Index = 5, Name = "PAX Sivir" }
                        ,new Skin() { Index = 6, Name = "Snowstorm Sivir" }
                        })}
                        ,{ "Riven", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Redeemed Riven" }
                        ,new Skin() { Index = 2, Name = "Crimson Elite Riven" }
                        ,new Skin() { Index = 3, Name = "Battle Bunny Riven" }
                        ,new Skin() { Index = 4, Name = "Championship Riven" }
                        ,new Skin() { Index = 5, Name = "Dragonblade Riven" }
                        })}
                        ,{ "Orianna", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Gothic Orianna" }
                        ,new Skin() { Index = 2, Name = "Sewn Chaos Orianna" }
                        ,new Skin() { Index = 3, Name = "Bladecraft Orianna" }
                        ,new Skin() { Index = 4, Name = "TPA Orianna" }
                        })}
                        ,{ "Gangplank", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Spooky Gangplank" }
                        ,new Skin() { Index = 2, Name = "Minuteman Gangplank" }
                        ,new Skin() { Index = 3, Name = "Sailor Gangplank" }
                        ,new Skin() { Index = 4, Name = "Toy Soldier Gangplank" }
                        ,new Skin() { Index = 5, Name = "Special Forces Gangplank" }
                        ,new Skin() { Index = 6, Name = "Sultan Gangplank" }
                        })}
                        ,{ "Malphite", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Shamrock Malphite" }
                        ,new Skin() { Index = 2, Name = "Coral Reef Malphite" }
                        ,new Skin() { Index = 3, Name = "Marble Malphite" }
                        ,new Skin() { Index = 4, Name = "Obsidian Malphite" }
                        ,new Skin() { Index = 5, Name = "Glacial Malphite" }
                        ,new Skin() { Index = 6, Name = "Mecha Malphite" }
                        })}
                        ,{ "Poppy", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Noxus Poppy" }
                        ,new Skin() { Index = 2, Name = "Lollipoppy" }
                        ,new Skin() { Index = 3, Name = "Blacksmith Poppy" }
                        ,new Skin() { Index = 4, Name = "Ragdoll Poppy" }
                        ,new Skin() { Index = 5, Name = "Battle Regalia Poppy" }
                        ,new Skin() { Index = 6, Name = "Scarlet Hammer Poppy" }
                        })}
                        ,{ "Karthus", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Phantom Karthus" }
                        ,new Skin() { Index = 2, Name = "Statue of Karthus" }
                        ,new Skin() { Index = 3, Name = "Grim Reaper Karthus" }
                        ,new Skin() { Index = 4, Name = "Pentakill Karthus" }
                        ,new Skin() { Index = 5, Name = "Fnatic Karthus" }
                        })}
                        ,{ "Jayce", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Full Metal Jayce" }
                        ,new Skin() { Index = 2, Name = "Debonair Jayce" }
                        })}
                        ,{ "Nunu", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Sasquatch Nunu" }
                        ,new Skin() { Index = 2, Name = "Workshop Nunu" }
                        ,new Skin() { Index = 3, Name = "Grungy Nunu" }
                        ,new Skin() { Index = 4, Name = "Nunu Bot" }
                        ,new Skin() { Index = 5, Name = "Demolisher Nunu" }
                        ,new Skin() { Index = 6, Name = "TPA Nunu" }
                        })}
                        ,{ "Trundle", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Lil' Slugger Trundle" }
                        ,new Skin() { Index = 2, Name = "Junkyard Trundle" }
                        ,new Skin() { Index = 3, Name = "Traditional Trundle" }
                        })}
                        ,{ "Graves", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Hired Gun Graves" }
                        ,new Skin() { Index = 2, Name = "Jailbreak Graves" }
                        ,new Skin() { Index = 3, Name = "Mafia Graves" }
                        ,new Skin() { Index = 4, Name = "Riot Graves" }
                        ,new Skin() { Index = 5, Name = "Pool Party Graves" }
                        })}
                        ,{ "Morgana", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Exiled Morgana" }
                        ,new Skin() { Index = 2, Name = "Sinful Succulence Morgana" }
                        ,new Skin() { Index = 3, Name = "Blade Mistress Morgana" }
                        ,new Skin() { Index = 4, Name = "Blackthorn Morgana" }
                        ,new Skin() { Index = 5, Name = "Ghost Bride Morgana" }
                        ,new Skin() { Index = 6, Name = "Victorious Morgana" }
                        })}
                        ,{ "Gnar", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Dino Gnar" }
                        })}
                        ,{ "Lux", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Sorceress Lux" }
                        ,new Skin() { Index = 2, Name = "Spellthief Lux" }
                        ,new Skin() { Index = 3, Name = "Commando Lux" }
                        ,new Skin() { Index = 4, Name = "Imperial Lux" }
                        ,new Skin() { Index = 5, Name = "Steel Legion Lux" }
                        })}
                        ,{ "Shyvana", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Ironscale Shyvana" }
                        ,new Skin() { Index = 2, Name = "Boneclaw Shyvana" }
                        ,new Skin() { Index = 3, Name = "Darkflame Shyvana" }
                        ,new Skin() { Index = 4, Name = "Ice Drake Shyvana" }
                        ,new Skin() { Index = 5, Name = "Championship Shyvana" }
                        })}
                        ,{ "Renekton", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Galactic Renekton" }
                        ,new Skin() { Index = 2, Name = "Outback Renekton" }
                        ,new Skin() { Index = 3, Name = "Bloodfury Renekton" }
                        ,new Skin() { Index = 4, Name = "Rune Wars Renekton" }
                        ,new Skin() { Index = 5, Name = "Scorched Earth Renekton" }
                        ,new Skin() { Index = 6, Name = "Pool Party Renekton" }
                        })}
                        ,{ "Fiora", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Royal Guard Fiora" }
                        ,new Skin() { Index = 2, Name = "Nightraven Fiora" }
                        ,new Skin() { Index = 3, Name = "Headmistress Fiora" }
                        })}
                        ,{ "Jinx", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Mafia Jinx" }
                        })}
                        ,{ "Kalista", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Blood Moon Kalista" }
                        })}
                        ,{ "Fizz", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Atlantean Fizz" }
                        ,new Skin() { Index = 2, Name = "Tundra Fizz" }
                        ,new Skin() { Index = 3, Name = "Fisherman Fizz" }
                        ,new Skin() { Index = 4, Name = "Void Fizz" }
                        })}
                        ,{ "Kassadin", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Festival Kassadin" }
                        ,new Skin() { Index = 2, Name = "Deep One Kassadin" }
                        ,new Skin() { Index = 3, Name = "Pre-Void Kassadin" }
                        ,new Skin() { Index = 4, Name = "Harbinger Kassadin" }
                        })}
                        ,{ "Sona", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Muse Sona" }
                        ,new Skin() { Index = 2, Name = "Pentakill Sona" }
                        ,new Skin() { Index = 3, Name = "Silent Night Sona" }
                        ,new Skin() { Index = 4, Name = "Guqin Sona" }
                        ,new Skin() { Index = 5, Name = "Arcade Sona" }
                        })}
                        ,{ "Irelia", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Nightblade Irelia" }
                        ,new Skin() { Index = 2, Name = "Aviator Irelia" }
                        ,new Skin() { Index = 3, Name = "Infiltrator Irelia" }
                        ,new Skin() { Index = 4, Name = "Frostblade Irelia" }
                        })}
                        ,{ "Viktor", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Full Machine Viktor" }
                        ,new Skin() { Index = 2, Name = "Prototype Viktor" }
                        ,new Skin() { Index = 3, Name = "Creator Viktor" }
                        })}
                        ,{ "Cassiopeia", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Desperada Cassiopeia" }
                        ,new Skin() { Index = 2, Name = "Siren Cassiopeia" }
                        ,new Skin() { Index = 3, Name = "Mythic Cassiopeia" }
                        ,new Skin() { Index = 4, Name = "Jade Fang Cassiopeia" }
                        })}
                        ,{ "Maokai", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Charred Maokai" }
                        ,new Skin() { Index = 2, Name = "Totemic Maokai" }
                        ,new Skin() { Index = 3, Name = "Festive Maokai" }
                        ,new Skin() { Index = 4, Name = "Haunted Maokai" }
                        ,new Skin() { Index = 5, Name = "Goalkeeper Maokai" }
                        })}
                        ,{ "Thresh", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Deep Terror Thresh" }
                        ,new Skin() { Index = 2, Name = "Championship Thresh" }
                        })}
                        ,{ "Kayle", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Silver Kayle" }
                        ,new Skin() { Index = 2, Name = "Viridian Kayle" }
                        ,new Skin() { Index = 3, Name = "Unmasked Kayle" }
                        ,new Skin() { Index = 4, Name = "Battleborn Kayle" }
                        ,new Skin() { Index = 5, Name = "Judgment Kayle" }
                        ,new Skin() { Index = 6, Name = "Aether Wing Kayle" }
                        ,new Skin() { Index = 7, Name = "Riot Kayle" }
                        })}
                        ,{ "Hecarim", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Blood Knight Hecarim" }
                        ,new Skin() { Index = 2, Name = "Reaper Hecarim" }
                        ,new Skin() { Index = 3, Name = "Headless Hecarim" }
                        ,new Skin() { Index = 4, Name = "Arcade Hecarim" }
                        })}
                        ,{ "Kha'Zix", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Mecha Kha'Zix" }
                        ,new Skin() { Index = 2, Name = "Guardian of the Sands Kha'Zix" }
                        })}
                        ,{ "Olaf", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Forsaken Olaf" }
                        ,new Skin() { Index = 2, Name = "Glacial Olaf" }
                        ,new Skin() { Index = 3, Name = "Brolaf" }
                        ,new Skin() { Index = 4, Name = "Pentakill Olaf" }
                        })}
                        ,{ "Ziggs", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Mad Scientist Ziggs" }
                        ,new Skin() { Index = 2, Name = "Major Ziggs" }
                        ,new Skin() { Index = 3, Name = "Pool Party Ziggs" }
                        ,new Skin() { Index = 4, Name = "Snow Day Ziggs" }
                        })}
                        ,{ "Syndra", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Justicar Syndra" }
                        ,new Skin() { Index = 2, Name = "Atlantean Syndra" }
                        })}
                        ,{ "Dr. Mundo", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Toxic Dr. Mundo" }
                        ,new Skin() { Index = 2, Name = "Mr. Mundoverse" }
                        ,new Skin() { Index = 3, Name = "Corporate Mundo" }
                        ,new Skin() { Index = 4, Name = "Mundo Mundo" }
                        ,new Skin() { Index = 5, Name = "Executioner Mundo" }
                        ,new Skin() { Index = 6, Name = "Rageborn Mundo" }
                        ,new Skin() { Index = 7, Name = "TPA Mundo" }
                        })}
                        ,{ "Karma", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Sun Goddess Karma" }
                        ,new Skin() { Index = 2, Name = "Sakura Karma" }
                        ,new Skin() { Index = 3, Name = "Traditional Karma" }
                        ,new Skin() { Index = 4, Name = "Order of the Lotus Karma" }
                        })}
                        ,{ "Annie", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Goth Annie" }
                        ,new Skin() { Index = 2, Name = "Red Riding Annie" }
                        ,new Skin() { Index = 3, Name = "Annie in Wonderland" }
                        ,new Skin() { Index = 4, Name = "Prom Queen Annie" }
                        ,new Skin() { Index = 5, Name = "Frostfire Annie" }
                        ,new Skin() { Index = 6, Name = "Reverse Annie" }
                        ,new Skin() { Index = 7, Name = "FrankenTibbers Annie" }
                        ,new Skin() { Index = 8, Name = "Panda Annie" }
                        })}
                        ,{ "Akali", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Stinger Akali" }
                        ,new Skin() { Index = 2, Name = "Crimson Akali" }
                        ,new Skin() { Index = 3, Name = "All-star Akali" }
                        ,new Skin() { Index = 4, Name = "Nurse Akali" }
                        ,new Skin() { Index = 5, Name = "Blood Moon Akali" }
                        ,new Skin() { Index = 6, Name = "Silverfang Akali" }
                        })}
                        ,{ "Volibear", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Thunder Lord Volibear" }
                        ,new Skin() { Index = 2, Name = "Northern Storm Volibear" }
                        ,new Skin() { Index = 3, Name = "Runeguard Volibear" }
                        })}
                        ,{ "Yasuo", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "High Noon Yasuo" }
                        ,new Skin() { Index = 2, Name = "PROJECT: Yasuo" }
                        })}
                        ,{ "Kennen", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Deadly Kennen" }
                        ,new Skin() { Index = 2, Name = "Swamp Master Kennen" }
                        ,new Skin() { Index = 3, Name = "Karate Kennen" }
                        ,new Skin() { Index = 4, Name = "Kennen M.D." }
                        ,new Skin() { Index = 5, Name = "Arctic Ops Kennen" }
                        })}
                        ,{ "Rengar", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Headhunter Rengar" }
                        ,new Skin() { Index = 2, Name = "Night Hunter Rengar" }
                        })}
                        ,{ "Ryze", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Human Ryze" }
                        ,new Skin() { Index = 2, Name = "Tribal Ryze" }
                        ,new Skin() { Index = 3, Name = "Uncle Ryze" }
                        ,new Skin() { Index = 4, Name = "Triumphant Ryze" }
                        ,new Skin() { Index = 5, Name = "Professor Ryze" }
                        ,new Skin() { Index = 6, Name = "Zombie Ryze" }
                        ,new Skin() { Index = 7, Name = "Dark Crystal Ryze" }
                        ,new Skin() { Index = 8, Name = "Pirate Ryze" }
                        })}
                        ,{ "Shen", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Frozen Shen" }
                        ,new Skin() { Index = 2, Name = "Yellow Jacket Shen" }
                        ,new Skin() { Index = 3, Name = "Surgeon Shen" }
                        ,new Skin() { Index = 4, Name = "Blood Moon Shen" }
                        ,new Skin() { Index = 5, Name = "Warlord Shen" }
                        ,new Skin() { Index = 6, Name = "TPA Shen" }
                        })}
                        ,{ "Zac", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Special Weapon Zac" }
                        })}
                        ,{ "Talon", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Renegade Talon" }
                        ,new Skin() { Index = 2, Name = "Crimson Elite Talon" }
                        ,new Skin() { Index = 3, Name = "Dragonblade Talon" }
                        })}
                        ,{ "Swain", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Northern Front Swain" }
                        ,new Skin() { Index = 2, Name = "Bilgewater Swain" }
                        ,new Skin() { Index = 3, Name = "Tyrant Swain" }
                        })}
                        ,{ "Sion", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Hextech Sion" }
                        ,new Skin() { Index = 2, Name = "Barbarian Sion" }
                        ,new Skin() { Index = 3, Name = "Lumberjack Sion" }
                        ,new Skin() { Index = 4, Name = "Warmonger Sion" }
                        })}
                        ,{ "Vayne", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Vindicator Vayne" }
                        ,new Skin() { Index = 2, Name = "Aristocrat Vayne" }
                        ,new Skin() { Index = 3, Name = "Dragonslayer Vayne" }
                        ,new Skin() { Index = 4, Name = "Heartseeker Vayne" }
                        ,new Skin() { Index = 5, Name = "SKT T1 Vayne" }
                        })}
                        ,{ "Nasus", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Galactic Nasus" }
                        ,new Skin() { Index = 2, Name = "Pharaoh Nasus" }
                        ,new Skin() { Index = 3, Name = "Dreadknight Nasus" }
                        ,new Skin() { Index = 4, Name = "Riot K-9 Nasus" }
                        ,new Skin() { Index = 5, Name = "Infernal Nasus" }
                        })}
                        ,{ "Twisted Fate", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "PAX Twisted Fate" }
                        ,new Skin() { Index = 2, Name = "Jack of Hearts Twisted Fate" }
                        ,new Skin() { Index = 3, Name = "The Magnificent Twisted Fate" }
                        ,new Skin() { Index = 4, Name = "Tango Twisted Fate" }
                        ,new Skin() { Index = 5, Name = "High Noon Twisted Fate" }
                        ,new Skin() { Index = 6, Name = "Musketeer Twisted Fate" }
                        ,new Skin() { Index = 7, Name = "Underworld Twisted Fate" }
                        ,new Skin() { Index = 8, Name = "Red Card Twisted Fate" }
                        })}
                        ,{ "Cho'Gath", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Nightmare Cho'Gath" }
                        ,new Skin() { Index = 2, Name = "Gentleman Cho'Gath" }
                        ,new Skin() { Index = 3, Name = "Loch Ness Cho'Gath" }
                        ,new Skin() { Index = 4, Name = "Jurassic Cho'Gath" }
                        ,new Skin() { Index = 5, Name = "Battlecast Prime Cho'Gath" }
                        })}
                        ,{ "Udyr", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Black Belt Udyr" }
                        ,new Skin() { Index = 2, Name = "Primal Udyr" }
                        ,new Skin() { Index = 3, Name = "Spirit Guard Udyr" }
                        })}
                        ,{ "Lucian", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Hired Gun Lucian" }
                        ,new Skin() { Index = 2, Name = "Striker Lucian" }
                        })}
                        ,{ "Leona", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Valkyrie Leona" }
                        ,new Skin() { Index = 2, Name = "Defender Leona" }
                        ,new Skin() { Index = 3, Name = "Iron Solari Leona" }
                        ,new Skin() { Index = 4, Name = "Pool Party Leona" }
                        })}
                        ,{ "Caitlyn", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Resistance Caitlyn" }
                        ,new Skin() { Index = 2, Name = "Sheriff Caitlyn" }
                        ,new Skin() { Index = 3, Name = "Safari Caitlyn" }
                        ,new Skin() { Index = 4, Name = "Arctic Warfare Caitlyn" }
                        ,new Skin() { Index = 5, Name = "Officer Caitlyn" }
                        ,new Skin() { Index = 6, Name = "Headhunter Caitlyn" }
                        })}
                        ,{ "Sejuani", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Sabretusk Sejuani" }
                        ,new Skin() { Index = 2, Name = "Darkrider Sejuani" }
                        ,new Skin() { Index = 3, Name = "Traditional Sejuani" }
                        ,new Skin() { Index = 4, Name = "Bear Cavalry Sejuani" }
                        })}
                        ,{ "Nocturne", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Frozen Terror Nocturne" }
                        ,new Skin() { Index = 2, Name = "Void Nocturne" }
                        ,new Skin() { Index = 3, Name = "Ravager Nocturne" }
                        ,new Skin() { Index = 4, Name = "Haunting Nocturne" }
                        ,new Skin() { Index = 5, Name = "Eternum Nocturne" }
                        })}
                        ,{ "Zilean", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Old Saint Zilean" }
                        ,new Skin() { Index = 2, Name = "Groovy Zilean" }
                        ,new Skin() { Index = 3, Name = "Shurima Desert Zilean" }
                        ,new Skin() { Index = 4, Name = "Time Machine Zilean" }
                        })}
                        ,{ "Azir", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Galactic Azir" }
                        })}
                        ,{ "Rumble", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Rumble in the Jungle" }
                        ,new Skin() { Index = 2, Name = "Bilgerat Rumble" }
                        ,new Skin() { Index = 3, Name = "Super Galaxy Rumble" }
                        })}
                        ,{ "Skarner", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Sandscourge Skarner" }
                        ,new Skin() { Index = 2, Name = "Earthrune Skarner" }
                        ,new Skin() { Index = 3, Name = "Battlecast Alpha Skarner" }
                        })}
                        ,{ "Teemo", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Happy Elf Teemo" }
                        ,new Skin() { Index = 2, Name = "Recon Teemo" }
                        ,new Skin() { Index = 3, Name = "Badger Teemo" }
                        ,new Skin() { Index = 4, Name = "Astronaut Teemo" }
                        ,new Skin() { Index = 5, Name = "Cottontail Teemo" }
                        ,new Skin() { Index = 6, Name = "Super Teemo" }
                        ,new Skin() { Index = 7, Name = "Panda Teemo" }
                        })}
                        ,{ "Urgot", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Giant Enemy Crabgot" }
                        ,new Skin() { Index = 2, Name = "Butcher Urgot" }
                        ,new Skin() { Index = 3, Name = "Battlecast Urgot" }
                        })}
                        ,{ "Amumu", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Pharaoh Amumu" }
                        ,new Skin() { Index = 2, Name = "Vancouver Amumu" }
                        ,new Skin() { Index = 3, Name = "Emumu" }
                        ,new Skin() { Index = 4, Name = "Re-Gifted Amumu" }
                        ,new Skin() { Index = 5, Name = "Almost-Prom King Amumu" }
                        ,new Skin() { Index = 6, Name = "Little Knight Amumu" }
                        ,new Skin() { Index = 7, Name = "Sad Robot Amumu" }
                        })}
                        ,{ "Galio", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Enchanted Galio" }
                        ,new Skin() { Index = 2, Name = "Hextech Galio" }
                        ,new Skin() { Index = 3, Name = "Commando Galio" }
                        ,new Skin() { Index = 4, Name = "Gatekeeper Galio" }
                        })}
                        ,{ "Heimerdinger", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Alien Invader Heimerdinger" }
                        ,new Skin() { Index = 2, Name = "Blast Zone Heimerdinger" }
                        ,new Skin() { Index = 3, Name = "Piltover Customs Heimerdinger" }
                        ,new Skin() { Index = 4, Name = "Snowmerdinger" }
                        ,new Skin() { Index = 5, Name = "Hazmat Heimerdinger" }
                        })}
                        ,{ "Anivia", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Team Spirit Anivia" }
                        ,new Skin() { Index = 2, Name = "Bird of Prey Anivia" }
                        ,new Skin() { Index = 3, Name = "Noxus Hunter Anivia" }
                        ,new Skin() { Index = 4, Name = "Hextech Anivia" }
                        ,new Skin() { Index = 5, Name = "Blackfrost Anivia" }
                        })}
                        ,{ "Ashe", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Freljord Ashe" }
                        ,new Skin() { Index = 2, Name = "Sherwood Forest Ashe" }
                        ,new Skin() { Index = 3, Name = "Woad Ashe" }
                        ,new Skin() { Index = 4, Name = "Queen Ashe" }
                        ,new Skin() { Index = 5, Name = "Amethyst Ashe" }
                        ,new Skin() { Index = 6, Name = "Heartseeker Ashe" }
                        })}
                        ,{ "Vel'Koz", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Battlecast Vel'Koz" }
                        })}
                        ,{ "Singed", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Riot Squad Singed" }
                        ,new Skin() { Index = 2, Name = "Hextech Singed" }
                        ,new Skin() { Index = 3, Name = "Surfer Singed" }
                        ,new Skin() { Index = 4, Name = "Mad Scientist Singed" }
                        ,new Skin() { Index = 5, Name = "Augmented Singed" }
                        ,new Skin() { Index = 6, Name = "Snow Day Singed" }
                        })}
                        ,{ "Varus", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Blight Crystal Varus" }
                        ,new Skin() { Index = 2, Name = "Arclight Varus" }
                        ,new Skin() { Index = 3, Name = "Arctic Ops Varus" }
                        })}
                        ,{ "Twitch", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Kingpin Twitch" }
                        ,new Skin() { Index = 2, Name = "Whistler Village Twitch" }
                        ,new Skin() { Index = 3, Name = "Medieval Twitch" }
                        ,new Skin() { Index = 4, Name = "Gangster Twitch" }
                        ,new Skin() { Index = 5, Name = "Vandal Twitch" }
                        })}
                        ,{ "Garen", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Sanguine Garen" }
                        ,new Skin() { Index = 2, Name = "Desert Trooper Garen" }
                        ,new Skin() { Index = 3, Name = "Commando Garen" }
                        ,new Skin() { Index = 4, Name = "Dreadknight Garen" }
                        ,new Skin() { Index = 5, Name = "Rugged Garen" }
                        ,new Skin() { Index = 6, Name = "Steel Legion Garen" }
                        })}
                        ,{ "Blitzcrank", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Rusty Blitzcrank" }
                        ,new Skin() { Index = 2, Name = "Goalkeeper Blitzcrank" }
                        ,new Skin() { Index = 3, Name = "Boom Boom Blitzcrank" }
                        ,new Skin() { Index = 4, Name = "Piltover Customs Blitzcrank" }
                        ,new Skin() { Index = 5, Name = "Definitely Not Blitzcrank" }
                        ,new Skin() { Index = 6, Name = "iBlitzcrank" }
                        ,new Skin() { Index = 7, Name = "Riot Blitzcrank" }
                        })}
                        ,{ "Master Yi", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Assassin Master Yi" }
                        ,new Skin() { Index = 2, Name = "Chosen Master Yi" }
                        ,new Skin() { Index = 3, Name = "Ionia Master Yi" }
                        ,new Skin() { Index = 4, Name = "Samurai Yi" }
                        ,new Skin() { Index = 5, Name = "Headhunter Master Yi" }
                        })}
                        ,{ "Elise", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Death Blossom Elise" }
                        ,new Skin() { Index = 2, Name = "Victorious Elise" }
                        })}
                        ,{ "Alistar", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Black Alistar" }
                        ,new Skin() { Index = 2, Name = "Golden Alistar" }
                        ,new Skin() { Index = 3, Name = "Matador Alistar" }
                        ,new Skin() { Index = 4, Name = "Longhorn Alistar" }
                        ,new Skin() { Index = 5, Name = "Unchained Alistar" }
                        ,new Skin() { Index = 6, Name = "Infernal Alistar" }
                        ,new Skin() { Index = 7, Name = "Sweeper Alistar" }
                        })}
                        ,{ "Katarina", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Mercenary Katarina" }
                        ,new Skin() { Index = 2, Name = "Red Card Katarina" }
                        ,new Skin() { Index = 3, Name = "Bilgewater Katarina" }
                        ,new Skin() { Index = 4, Name = "Kitty Cat Katarina" }
                        ,new Skin() { Index = 5, Name = "High Command Katarina" }
                        ,new Skin() { Index = 6, Name = "Sandstorm Katarina" }
                        ,new Skin() { Index = 7, Name = "Slay Belle Katarina" }
                        })}
                        ,{ "Mordekaiser", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Dragon Knight Mordekaiser" }
                        ,new Skin() { Index = 2, Name = "Infernal Mordekaiser" }
                        ,new Skin() { Index = 3, Name = "Pentakill Mordekaiser" }
                        ,new Skin() { Index = 4, Name = "Lord Mordekaiser" }
                        })}
                        ,{ "Lulu", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Bittersweet Lulu" }
                        ,new Skin() { Index = 2, Name = "Wicked Lulu" }
                        ,new Skin() { Index = 3, Name = "Dragon Trainer Lulu" }
                        ,new Skin() { Index = 4, Name = "Winter Wonder Lulu" }
                        })}
                        ,{ "Aatrox", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Justicar Aatrox" }
                        ,new Skin() { Index = 2, Name = "Mecha Aatrox" }
                        })}
                        ,{ "Draven", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Soul Reaver Draven" }
                        ,new Skin() { Index = 2, Name = "Gladiator Draven" }
                        ,new Skin() { Index = 3, Name = "Primetime Draven" }
                        })}
                        ,{ "Fiddlesticks", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Spectral Fiddlesticks" }
                        ,new Skin() { Index = 2, Name = "Union Jack Fiddlesticks" }
                        ,new Skin() { Index = 3, Name = "Bandito Fiddlesticks" }
                        ,new Skin() { Index = 4, Name = "Pumpkinhead Fiddlesticks" }
                        ,new Skin() { Index = 5, Name = "Fiddle Me Timbers" }
                        ,new Skin() { Index = 6, Name = "Surprise Party Fiddlesticks" }
                        ,new Skin() { Index = 7, Name = "Dark Candy Fiddlesticks" }
                        })}
                        ,{ "Pantheon", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Myrmidon Pantheon" }
                        ,new Skin() { Index = 2, Name = "Ruthless Pantheon" }
                        ,new Skin() { Index = 3, Name = "Perseus Pantheon" }
                        ,new Skin() { Index = 4, Name = "Full Metal Pantheon" }
                        ,new Skin() { Index = 5, Name = "Glaive Warrior Pantheon" }
                        ,new Skin() { Index = 6, Name = "Dragonslayer Pantheon" }
                        })}
                        ,{ "Xin Zhao", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Commando Xin Zhao" }
                        ,new Skin() { Index = 2, Name = "Imperial Xin Zhao" }
                        ,new Skin() { Index = 3, Name = "Viscero Xin Zhao" }
                        ,new Skin() { Index = 4, Name = "Winged Hussar Xin Zhao" }
                        ,new Skin() { Index = 5, Name = "Warring Kingdoms Xin Zhao" }
                        })}
                        ,{ "Lee Sin", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Traditional Lee Sin" }
                        ,new Skin() { Index = 2, Name = "Acolyte Lee Sin" }
                        ,new Skin() { Index = 3, Name = "Dragon Fist Lee Sin" }
                        ,new Skin() { Index = 4, Name = "Muay Thai Lee Sin" }
                        ,new Skin() { Index = 5, Name = "Pool Party Lee Sin" }
                        ,new Skin() { Index = 6, Name = "SKT T1 Lee Sin" }
                        })}
                        ,{ "Taric", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Emerald Taric" }
                        ,new Skin() { Index = 2, Name = "Armor of the Fifth Age Taric" }
                        ,new Skin() { Index = 3, Name = "Bloodstone Taric" }
                        })}
                        ,{ "Malzahar", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Vizier Malzahar" }
                        ,new Skin() { Index = 2, Name = "Shadow Prince Malzahar" }
                        ,new Skin() { Index = 3, Name = "Djinn Malzahar" }
                        ,new Skin() { Index = 4, Name = "Overlord Malzahar" }
                        })}
                        ,{ "Lissandra", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Bloodstone Lissandra" }
                        ,new Skin() { Index = 2, Name = "Blade Queen Lissandra" }
                        })}
                        ,{ "Diana", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Dark Valkyrie Diana" }
                        ,new Skin() { Index = 2, Name = "Lunar Goddess Diana" }
                        })}
                        ,{ "Tristana", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Riot Girl Tristana" }
                        ,new Skin() { Index = 2, Name = "Earnest Elf Tristana" }
                        ,new Skin() { Index = 3, Name = "Firefighter Tristana" }
                        ,new Skin() { Index = 4, Name = "Guerilla Tristana" }
                        ,new Skin() { Index = 5, Name = "Buccaneer Tristana" }
                        ,new Skin() { Index = 6, Name = "Rocket Girl Tristana" }
                        })}
                        ,{ "Vladimir", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Count Vladimir" }
                        ,new Skin() { Index = 2, Name = "Marquis Vladimir" }
                        ,new Skin() { Index = 3, Name = "Nosferatu Vladimir" }
                        ,new Skin() { Index = 4, Name = "Vandal Vladimir" }
                        ,new Skin() { Index = 5, Name = "Blood Lord Vladimir" }
                        ,new Skin() { Index = 6, Name = "Soulstealer Vladimir" }
                        })}
                        ,{ "Jarvan IV", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Commando Jarvan IV" }
                        ,new Skin() { Index = 2, Name = "Dragonslayer Jarvan IV" }
                        ,new Skin() { Index = 3, Name = "Darkforge Jarvan IV" }
                        ,new Skin() { Index = 4, Name = "Victorious Jarvan IV" }
                        ,new Skin() { Index = 5, Name = "Warring Kingdoms Jarvan IV" }
                        ,new Skin() { Index = 6, Name = "Fnatic Jarvan IV" }
                        })}
                        ,{ "Nami", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Koi Nami" }
                        ,new Skin() { Index = 2, Name = "River Spirit Nami" }
                        })}
                        ,{ "Soraka", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Dryad Soraka" }
                        ,new Skin() { Index = 2, Name = "Divine Soraka" }
                        ,new Skin() { Index = 3, Name = "Celestine Soraka" }
                        ,new Skin() { Index = 4, Name = "Reaper Soraka" }
                        })}
                        ,{ "Veigar", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "White Mage Veigar" }
                        ,new Skin() { Index = 2, Name = "Curling Veigar" }
                        ,new Skin() { Index = 3, Name = "Veigar Greybeard" }
                        ,new Skin() { Index = 4, Name = "Leprechaun Veigar" }
                        ,new Skin() { Index = 5, Name = "Baron Von Veigar" }
                        ,new Skin() { Index = 6, Name = "Superb Villain Veigar" }
                        ,new Skin() { Index = 7, Name = "Bad Santa Veigar" }
                        ,new Skin() { Index = 8, Name = "Final Boss Veigar" }
                        })}
                        ,{ "Janna", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Tempest Janna" }
                        ,new Skin() { Index = 2, Name = "Hextech Janna" }
                        ,new Skin() { Index = 3, Name = "Frost Queen Janna" }
                        ,new Skin() { Index = 4, Name = "Victorious Janna" }
                        ,new Skin() { Index = 5, Name = "Forecast Janna" }
                        ,new Skin() { Index = 6, Name = "Fnatic Janna" }
                        })}
                        ,{ "Nautilus", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Abyssal Nautilus" }
                        ,new Skin() { Index = 2, Name = "Subterranean Nautilus" }
                        ,new Skin() { Index = 3, Name = "AstroNautilus" }
                        })}
                        ,{ "Evelynn", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Shadow Evelynn" }
                        ,new Skin() { Index = 2, Name = "Masquerade Evelynn" }
                        ,new Skin() { Index = 3, Name = "Tango Evelynn" }
                        })}
                        ,{ "Gragas", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Scuba Gragas" }
                        ,new Skin() { Index = 2, Name = "Hillbilly Gragas" }
                        ,new Skin() { Index = 3, Name = "Santa Gragas" }
                        ,new Skin() { Index = 4, Name = "Gragas, Esq." }
                        ,new Skin() { Index = 5, Name = "Vandal Gragas" }
                        ,new Skin() { Index = 6, Name = "Oktoberfest Gragas" }
                        ,new Skin() { Index = 7, Name = "Superfan Gragas" }
                        ,new Skin() { Index = 8, Name = "Fnatic Gragas" }
                        })}
                        ,{ "Zed", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Shockblade Zed" }
                        ,new Skin() { Index = 2, Name = "SKT T1 Zed" }
                        })}
                        ,{ "Vi", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Neon Strike Vi" }
                        ,new Skin() { Index = 2, Name = "Officer Vi" }
                        ,new Skin() { Index = 3, Name = "Debonair Vi" }
                        })}
                        ,{ "Kog'Maw", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Caterpillar Kog'Maw" }
                        ,new Skin() { Index = 2, Name = "Sonoran Kog'Maw" }
                        ,new Skin() { Index = 3, Name = "Monarch Kog'Maw" }
                        ,new Skin() { Index = 4, Name = "Reindeer Kog'Maw" }
                        ,new Skin() { Index = 5, Name = "Lion Dance Kog'Maw" }
                        ,new Skin() { Index = 6, Name = "Deep Sea Kog'Maw" }
                        ,new Skin() { Index = 7, Name = "Jurassic Kog'Maw" }
                        ,new Skin() { Index = 8, Name = "Battlecast Kog'Maw" }
                        })}
                        ,{ "Ahri", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Dynasty Ahri" }
                        ,new Skin() { Index = 2, Name = "Midnight Ahri" }
                        ,new Skin() { Index = 3, Name = "Foxfire Ahri" }
                        ,new Skin() { Index = 4, Name = "Popstar Ahri" }
                        })}
                        ,{ "Quinn", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Phoenix Quinn" }
                        ,new Skin() { Index = 2, Name = "Woad Scout Quinn" }
                        })}
                        ,{ "LeBlanc", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Wicked LeBlanc" }
                        ,new Skin() { Index = 2, Name = "Prestigious LeBlanc" }
                        ,new Skin() { Index = 3, Name = "Mistletoe LeBlanc" }
                        ,new Skin() { Index = 4, Name = "Ravenborn LeBlanc" }
                        })}
                        ,{ "Ezreal", new Skins(new Skin[] {new Skin() { Index = 0, Name = "default" }
                        ,new Skin() { Index = 1, Name = "Nottingham Ezreal" }
                        ,new Skin() { Index = 2, Name = "Striker Ezreal" }
                        ,new Skin() { Index = 3, Name = "Frosted Ezreal" }
                        ,new Skin() { Index = 4, Name = "Explorer Ezreal" }
                        ,new Skin() { Index = 5, Name = "Pulsefire Ezreal" }
                        ,new Skin() { Index = 6, Name = "TPA Ezreal" }
                        ,new Skin() { Index = 7, Name = "Debonair Ezreal" }
                        })}
                };
    }
}
