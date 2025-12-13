namespace PortalWars.Web.Data;

public static class PartyData
{
    public static PartyModel Current { get; } = new PartyModel
    {
        PartyName = "Portal Wars",
        Motto = "Hold the Line. Close the Rift.",
        CurrentLocation = "Sandpoint (Last Known)",
        Status = "Ongoing",
        StandardImageUrl = null, // put /images/standard.png later

        Members =
        [
            new PartyMember
            {
                Name = "Brian",
                PlayerName = null,
                Race = "Human",
                Class = "Fighter",
                Archetype = "Ex-Marine",
                Level = 1,
                Alignment = "—",
                DeityOrPhilosophy = "—",
                Hook = "A displaced outsider hardened by another world’s wars.",
                PortraitUrl = null,
                PersonalSigilUrl = null,
                SignatureItem = "Improvised club (for now)",
                Vitals = new CharacterVitals { AC = 16, HP = 12, Perception = 3 }
            },
            new PartyMember
            {
                Name = "PC 2",
                PlayerName = null,
                Race = "—",
                Class = "—",
                Archetype = null,
                Level = 1,
                Alignment = "—",
                DeityOrPhilosophy = "—",
                Hook = "Class / race / quick hook.",
                PortraitUrl = null,
                PersonalSigilUrl = null,
                SignatureItem = "—",
                Vitals = new CharacterVitals { AC = null, HP = null, Perception = null }
            }
        ],

        Companions =
        [
            // Examples (delete if you want)
            new Companion
            {
                Name = "Ironpaw",
                Type = "Animal Companion",
                Owner = "Brian",
                Role = "Scout & bruiser",
                Hook = "War-trained wolf with an unsettling calm.",
                PortraitUrl = null
            }
        ],

        Assets =
        [
            new PartyAsset { Name = "Shared Bag", Category = "Gear", Notes = "Party storage / loot hauling." },
            new PartyAsset { Name = "Portal Keystone", Category = "Relic", Notes = "Ancient device that stabilizes rifts (unreliable)." }
        ]
    };
}

public sealed class PartyModel
{
    public string PartyName { get; set; } = "The Party";
    public string? Motto { get; set; }
    public string? CurrentLocation { get; set; }
    public string? Status { get; set; }
    public string? StandardImageUrl { get; set; }

    public List<PartyMember> Members { get; set; } = new();
    public List<Companion> Companions { get; set; } = new();
    public List<PartyAsset> Assets { get; set; } = new();
}

public sealed class PartyMember
{
    public string Name { get; set; } = "";
    public string? PlayerName { get; set; }

    public string Race { get; set; } = "";
    public string Class { get; set; } = "";
    public string? Archetype { get; set; }
    public int Level { get; set; } = 1;

    public string? Alignment { get; set; }
    public string? DeityOrPhilosophy { get; set; }

    public string Hook { get; set; } = "";
    public string? PortraitUrl { get; set; }
    public string? PersonalSigilUrl { get; set; }

    public string? SignatureItem { get; set; }
    public CharacterVitals? Vitals { get; set; }
}

public sealed class CharacterVitals
{
    public int? AC { get; set; }
    public int? HP { get; set; }
    public int? Perception { get; set; }
}

public sealed class Companion
{
    public string Name { get; set; } = "";
    public string Type { get; set; } = "";   // Cohort / Follower / Hireling / Animal Companion / Familiar
    public string? Owner { get; set; }        // which PC they belong to
    public string? Role { get; set; }
    public string? Hook { get; set; }
    public string? PortraitUrl { get; set; }
}

public sealed class PartyAsset
{
    public string Name { get; set; } = "";
    public string Category { get; set; } = "Asset";
    public string? Notes { get; set; }
}
