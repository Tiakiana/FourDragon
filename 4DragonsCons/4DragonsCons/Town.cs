using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DragonsCons
{
    enum Resources {
        wood,
        stone,
        iron,
        sea,
        ivory,
        salt,

    }

    class Town
    {
        List<Resources> resources;

        string name { get; set; }
        int material { get; set; }
        int research { get; set; }
        int nextResearch { get; set; }
        int food { get; set; }
        int population { get; set; }
        Player dragon { get; set; }

        List<Relation> relations;
        List<ICard> discoveries;
        List<ICard> assets;
        List<ICard> decisions;
        List<ICard> projects;
        List<ICard> ongoingProjects;

        List<ICard> discoveriesDisc;
        List<ICard> assetsDisc;
        List<ICard> decisionsDisc;
        List<ICard> projectsDisc;
        

        public Town()
        {
            resources = new List<Resources>();
            population = 1;
            name = "Godtham";
            material = 0;
            research = 0;
            food = 1;
            nextResearch = 3;
            ongoingProjects = new List<ICard>();
            relations = new List<Relation>();
            discoveries = new List<ICard>();
            assets = new List<ICard>();
            decisions = new List<ICard>();
            projects = new List<ICard>();
            discoveriesDisc = new List<ICard>();
            assetsDisc = new List<ICard>();
            decisionsDisc = new List<ICard>();
            projectsDisc = new List<ICard>();
            CardStartProject c1 = new CardStartProject(this);
            CardProduction c2 = new CardProduction(this);
            CardProduction c3 = new CardProduction(this);
            CardProduction c4 = new CardProduction(this);
            CardResearch c5 = new CardResearch(this);
            CardResearch c6 = new CardResearch(this);
            CardResearch c7 = new CardResearch(this);
            decisions.Add(c1);
            decisions.Add(c2);
            decisions.Add(c3);
            decisions.Add(c4);
            decisions.Add(c5);
            decisions.Add(c6);
            decisions.Add(c7);
            ScrambleStartDeck();
            CardHousing ch = new CardHousing(this);
            CardForrest cf = new CardForrest(this);
            discoveries.Add(cf);
            
            projects.Add(ch);

        }

        public string GetName() {
            return name;
        }
        // Getters and setters
        #region Region Getters and Setters
        public void SetMaterial(int chng) {
            material += chng;
        }
        public void SetFood(int chng)
        {
            food += chng;
        }
        public void SetPopulation(int chng)
        {
            population += chng;
        }
        public List<ICard> GetDiscoveries() {
            return discoveries;
        }
        public List<ICard> GetAssets()
        {
            return assets;
        }
        public List<ICard> GetOngoing() {
            return ongoingProjects;
        }
        public int GetMaterial() {
            return material;
        }

        public void SetDiscovery(int di) {
            research += di;
        }
        public int GetDiscovery() {
            return research;
        }
        public List<ICard> GetProjects() {
            return projects;
        }
        public List<Relation> GetRelations() {

            return relations;
        }
        public List<ICard> GetDecisions() {
            return decisions;
        }

        #endregion getters and setters


        void ScrambleStartDeck()
        {
            List<ICard> newdecisions = new List<ICard>();
            int chosencard;
            int decisionsCount = decisions.Count;
            for (int i = 0; i < decisionsCount; i++)
            {
                chosencard = Randomizer.rnd.Next(0, decisions.Count);
                newdecisions.Add(decisions[chosencard]);
                decisions.RemoveAt(chosencard);
            }

            decisions = newdecisions;
        }



        public string DrawCard() {
            string res = "";
            if (decisions.Count>0)
            {
                ICard drawnCard = decisions[0];
                drawnCard.OnDraw();
                decisionsDisc.Add(drawnCard);
                decisions.RemoveAt(0);
                res += drawnCard.ToString();
                return res;
            }
            else
            {
                 res += " " + name+ " reshuffles and draws ";
                ReshuffleDeckDecision();

               res+= DrawCard();
                return res;
            }
        }
        // Mangler at implementeres
        public void CheckFood() {
            
        }

       // ---------------------------------------------------Take The Turn! ----------------------------------

        internal string TakeTurn() {
            string s = name;

            for (int i = 0; i < population; i++)
            {
                s += " draws " + DrawCard();
            }

            if (ongoingProjects.Count>0 && ongoingProjects[0].cost<= material)
            {
                material -= ongoingProjects[0].cost;
                ongoingProjects[0].OnComplete();
            }

            if (discoveries.Count>0 && research>=nextResearch)
            {
                research -= nextResearch;
                nextResearch++;
                s += "\n" + name + " discovered " + discoveries[0].ToString();
                discoveries[0].OnDraw();
                
            }
            return s;

            
        }

        public void ReshuffleDeckDecision() {
            List<ICard> shuffledDeck = new List<ICard>();
            int decisionsDiscCount = decisionsDisc.Count;
            for (int i = 0; i < decisionsDiscCount; i++)
                {
                    int x = Randomizer.rnd.Next(0,decisionsDisc.Count);
                    shuffledDeck.Add(decisionsDisc[x]);
                decisionsDisc.RemoveAt(x);
                }
            foreach (ICard item in shuffledDeck)
            {
                decisions.Add(item);
            }

            }
        public override string ToString()
        {
            string s = "";
            if (ongoingProjects.Count>0)
            {
                foreach (ICard item in ongoingProjects)
                {
                    s += "and they are building " + item.ToString();
                }
            }


            return name + "; Material: " + material + " Research: " + research + " Population: " + population + " Food: " + food + " "+ s + "\n";
        }
    }

    
    }
    

