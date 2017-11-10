using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public abstract class s
    {
        public enum MissionType
        {
            AuctionOrder,
            BuyOrderSilver,
            ClaimOrb,
            CraftItem,
            CraftItemsSv,
            CraftItemFame,
            Die,
            DieSv,
            EnterCluster,
            EquipItem,
            SelectSpell,
            FindObject,
            Gather,
            GatherFame,
            GatherSilver,
            GrabLoot,
            GrabLootSv,
            HavePlayedGvgMatch,
            HaveFame,
            InstallSv,
            KillMob,
            KillMobFame,
            KillPlayer,
            KillPlayerFame,
            PlayGvgMatch,
            FameEarned,
            SellOrderSilver,
            Survive,
            FarmHarvest,
            FarmHarvestFame,
            FarmRaise,
            FarmRaiseFame,
            GotoAgent,
            EnterNonStartArea,
            AcquireItem,
            UseFunction,
            UseSpell,
            Num,
            Invalid = 37
        }

        public enum FightMode
        {
            all,
            pve,
            pvp,
            merc,
            gvg
        }

        public enum FightModeGvg
        {
            gvg,
            merc
        }

        public enum FightModePvp
        {
            pvp,
            gvg,
            merc
        }

        public enum UseFunctionType
        {
            Invalid,
            OpenWorldMap,
            OpenClusterMap,
            OpenDestinyBoard
        }

        [CompilerGenerated]
        private r a;

        [CompilerGenerated]
        private int b;

        [CompilerGenerated]
        private c1 c;

        [CompilerGenerated]
        private cr d;

        [CompilerGenerated]
        private string e;

        [CompilerGenerated]
        public r C3()
        {
            return this.a;
        }

        [CompilerGenerated]
        private void Bo(r A_0)
        {
            this.a = A_0;
        }

        [CompilerGenerated]
        public int C4()
        {
            return this.b;
        }

        [CompilerGenerated]
        private void Bo(int A_0)
        {
            this.b = A_0;
        }

        [CompilerGenerated]
        public c1 C5()
        {
            return this.c;
        }

        [CompilerGenerated]
        private void Bo(c1 A_0)
        {
            this.c = A_0;
        }

        [CompilerGenerated]
        public cr C6()
        {
            return this.d;
        }

        [CompilerGenerated]
        private void Bo(cr A_0)
        {
            this.d = A_0;
        }

        public abstract s.MissionType Bo();

        public abstract s Bp(Dictionary<string, c2.a> A_0, aln A_1);

        public abstract bool Bm(List<c2> A_0, List<string> A_1);

        public abstract bool Bn(hn A_0, List<string> A_1);

        [CompilerGenerated]
        public string C7()
        {
            return this.e;
        }

        [CompilerGenerated]
        protected void Cz(string A_0)
        {
            this.e = A_0;
        }

        public virtual void Bl(XmlElement A_0)
        {
            this.cz(al5.A(A_0, "textloca", string.Empty));
        }

        public virtual bool Bq(bg A_0, int A_1, hn A_2)
        {
            return bg.h(this.Bo());
        }

        public virtual bool Br(bg A_0, int A_1, hn A_2, List<string> A_3, HashSet<string> A_4)
        {
            if (!bg.h(A_0.j()))
            {
                A_3.Add("MissionType does not support Templates! type: " + this.Bo());
                return false;
            }
            return true;
        }

        public bool Bo(List<c2> A_0)
        {
            return this.Bm(A_0, null);
        }

        public bool Bo(hn A_0)
        {
            return this.Bn(A_0, null);
        }

        public s Cx(c1 A_0)
        {
            Dictionary<string, c2.a> a_ = A_0.f().u();
            s s = this.bp(a_, A_0.f().p());
            if (s != null)
            {
                s.Bo(A_0);
            }
            return s;
        }

        public static s Bo(string A_0, cr A_1)
        {
            s s = s.Bo(A_0);
            if (s != null)
            {
                s.Bo(A_1);
            }
            return s;
        }

        public static s Bo(string A_0, cv A_1)
        {
            return s.Bo(A_0);
        }

        public static s Bo(string A_0, ds A_1)
        {
            return s.Bo(A_0);
        }

        public static s Bo(string A_0, r A_1, int A_2)
        {
            s s = s.Bo(A_0);
            if (s != null)
            {
                s.Bo(A_1);
                s.Bo(A_2);
            }
            return s;
        }

        protected static s Bo(string A_0)
        {
            if (A_0 != null && A_0 == "gotocluster")
            {
                return s.Bo(s.MissionType.EnterCluster);
            }
            s result;
            try
            {
                s s = s.Bo((s.MissionType)Enum.Parse(typeof(s.MissionType), A_0, true));
                result = s;
            }
            catch (Exception ex)
            {
                ae6.A("MissionInfo.CreateByType: " + ex.Message);
                result = null;
            }
            return result;
        }

        public static s Bo(s.MissionType A_0, r A_1, int A_2)
        {
            s s = s.Bo(A_0);
            if (s != null)
            {
                s.Bo(A_1);
                s.Bo(A_2);
            }
            return s;
        }

        public static s Cx(s.MissionType A_0)
        {
            return s.Bo(A_0);
        }

        protected static s Bo(s.MissionType A_0)
        {
            switch (A_0)
            {
                case s.MissionType.AuctionOrder:
                    return new a2();
                case s.MissionType.BuyOrderSilver:
                    return new aj(A_0);
                case s.MissionType.ClaimOrb:
                    return new w();
                case s.MissionType.CraftItem:
                    return new a0();
                case s.MissionType.CraftItemsSv:
                    return new aj(A_0);
                case s.MissionType.CraftItemFame:
                    return new z();
                case s.MissionType.Die:
                    return new @as();
                case s.MissionType.DieSv:
                    return new al();
                case s.MissionType.EnterCluster:
                    return new am();
                case s.MissionType.EquipItem:
                    return new an();
                case s.MissionType.SelectSpell:
                    return new ac();
                case s.MissionType.FindObject:
                    return new ao();
                case s.MissionType.Gather:
                    return new aq();
                case s.MissionType.GatherFame:
                    return new ap();
                case s.MissionType.GatherSilver:
                    return new aj(A_0);
                case s.MissionType.GrabLoot:
                    return new ar();
                case s.MissionType.GrabLootSv:
                    return new at();
                case s.MissionType.HavePlayedGvgMatch:
                    return new az();
                case s.MissionType.HaveFame:
                    return new au();
                case s.MissionType.InstallSv:
                    return new ai();
                case s.MissionType.KillMob:
                    return new a1();
                case s.MissionType.KillMobFame:
                    return new ak();
                case s.MissionType.KillPlayer:
                    return new aw();
                case s.MissionType.KillPlayerFame:
                    return new av();
                case s.MissionType.PlayGvgMatch:
                    return new ay();
                case s.MissionType.FameEarned:
                    return new aj(A_0);
                case s.MissionType.SellOrderSilver:
                    return new aj(A_0);
                case s.MissionType.Survive:
                    return new ax();
                case s.MissionType.FarmHarvest:
                    return new ag();
                case s.MissionType.FarmHarvestFame:
                    return new ae();
                case s.MissionType.FarmRaise:
                    return new af();
                case s.MissionType.FarmRaiseFame:
                    return new ad();
                case s.MissionType.GotoAgent:
                    return new ah();
                case s.MissionType.EnterNonStartArea:
                    return new ab();
                case s.MissionType.AcquireItem:
                    return new aa();
                case s.MissionType.UseFunction:
                    return new v();
                case s.MissionType.UseSpell:
                    return new u();
                default:
                    return null;
            }
        }

        public static bool Bo(string A_0, c2.VariableType A_1, List<c2> A_2)
        {
            bool result = false;
            foreach (c2 current in A_2)
            {
                if (current.m() == A_0 && current.cl() == A_1)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
