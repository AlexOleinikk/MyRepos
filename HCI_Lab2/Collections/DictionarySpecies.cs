using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class DictionarySpecies
    {
        public Dictionary<string, string> species = new Dictionary<string, string>();

        public Dictionary<string, List<string>> subkingdom = new Dictionary<string, List<string>>();

        public Dictionary<string, List<string>> kingdom = new Dictionary<string, List<string>>();

        public DictionarySpecies()
        {
            Setup();
        }

        private void Setup()
        {
            SetupKingdom();

            SetupSubkingdom();

            SetupSpecies();
        }

        private void SetupKingdom()
        {
            kingdom.Add("Animals",
                new List<string>
                {
                    "Bilateria",
                    "Cnidaria",
                }
                );

            kingdom.Add("Plants",
                new List<string>
                {
                    "Magnoliophyta",
                    "Gnetóphyta",
                }
                );
        }

        private void SetupSubkingdom()
        {
            subkingdom.Add("Bilateria",
                new List<string>
                {
                    "Deuterostomia",
                    "Protostomia"
                }
                );

            subkingdom.Add("Cnidaria",
                new List<string>
                {
                    "Anthozoa",
                    "Cubozoa"
                }
                );

            subkingdom.Add("Magnoliophyta",
                new List<string>
                {
                    "Monocotyledones",
                    "Dicotyledones"
                }
                );

            subkingdom.Add("Gnetóphyta",
                new List<string>
                {
                    "Éphedra",
                    "Gnétum"
                }
                );
        }

        private void SetupSpecies()
        {
            species.Add("Deuterostomia",
                "The four major clades of deuterostomes are Chordata (e.g. vertebrates), Echinodermata (e.g. starfish), and Hemichordata (e.g. acorn worms). Together with Protostomia and their out-group Xenacoelomorpha, these compose the Bilateria, animals with bilateral symmetry and three germ layers.");

            species.Add("Protostomia",
                "Protostomia /proʊtoʊˈstoʊmiə/ is the clade of animals once thought to be characterized by the formation of the organism's mouth before its anus during embryonic development. This nature has since been discovered to be extremely variable among Protostomia's members, although the reverse is typically true of its sister clade, Deuterostomia.[1][2] Some examples of protostomes are nematodes, arthropods, flatworms, annelids and molluscs.");

            species.Add("Anthozoa",
                "Anthozoa is a class of marine invertebrates which includes the sea anemones, stony corals and soft corals. Adult anthozoans are almost all attached to the seabed, while their larvae can disperse as part of the plankton. The basic unit of the adult is the polyp; this consists of a cylindrical column topped by a disc with a central mouth surrounded by tentacles. Sea anemones are mostly solitary, but the majority of corals are colonial, being formed by the budding of new polyps from an original, founding individual. Colonies are strengthened by calcium carbonate and other materials and take various massive, plate-like, bushy or leafy forms.");

            species.Add("Cubozoa",
                "Box jellyfish (class Cubozoa) are cnidarian invertebrates distinguished by their box-like (i.e. cube-shaped) body.[2] Some species of box jellyfish produce potent venom delivered by contact with their tentacles. Stings from some species, including Chironex fleckeri, Carukia barnesi, Malo kingi, and a few others, are extremely painful and often fatal to humans. The box jellyfish can average up to 10 inches wide and 10 feet long and weigh up to 4.4 pounds.");

            species.Add("Monocotyledones",
                "Monocotyledons (/ˌmɒnəˌkɒtəlˈiːdən/),[d][13][14] commonly referred to as monocots, (Lilianae sensu Chase & Reveal) are grass and grass-like flowering plants (angiosperms), the seeds of which typically contain only one embryonic leaf, or cotyledon. They constitute one of the major groups into which the flowering plants have traditionally been divided, the rest of the flowering plants having two cotyledons and therefore classified as dicotyledons, or dicots.");

            species.Add("Dicotyledones",
                "The dicotyledons, also known as dicots (or more rarely dicotyls[2]), are one of the two groups into which all the flowering plants or angiosperms were formerly divided. The name refers to one of the typical characteristics of the group, namely that the seed has two embryonic leaves or cotyledons. There are around 200,000 species within this group.");

            species.Add("Éphedra",
                "Ephedra is a genus of gymnosperm shrubs. The various species of Ephedra are widespread in many arid regions of the world, ranging across southwestern North America, southern Europe, northern Africa, southwest and central Asia, northern China and western South America.[3] It is the only extant genus in its family, Ephedraceae, and order, Ephedrales and one of the three living members of the division Gnetophyta alongside Gnetum and Welwitschia.");

            species.Add("Gnétum",
                "Gnetum is a genus of gymnosperms, the sole genus in the family Gnetaceae and order Gnetales. They are tropical evergreen trees, shrubs and lianas. Unlike other gymnosperms, they possess vessel elements in the xylem. Some species have been proposed to have been the first plants to be insect-pollinated as their fossils occur in association with extinct pollinating scorpionflies.[2] Molecular phylogenies based on nuclear and plastid sequences from most of the species indicate hybridization among some of the Southeast Asian species.");
        }
    }
}
