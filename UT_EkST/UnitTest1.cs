using Microsoft.VisualStudio.TestTools.UnitTesting;
using EkST;

namespace UT_EkST
{
    [TestClass]
    public class UnitTest1
    {
        private Lohnsteuerrechner lohnsteuerrechner;
        private Parameter par;
        
        //////// allgemeine maschinelle Jahreslohnsteuer 2024 ////////
        
        ///////// STKL1 /////////

        [TestMethod, TestCategory("I"), TestCategory("5.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_5000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("7500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_7500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("10000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_10000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 1000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("12500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_12500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 1250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("15000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_15000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 1500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("17500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_17500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 1750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 165;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("20000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_20000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 2000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 550;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("22500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_22500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 2250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 990;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("25000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_25000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 2500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1478;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("27500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_27500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 2750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1982;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("30000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_30000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 3000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2501;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("32500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_32500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 3250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3033;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("35000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_35000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 3500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3581;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("37500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_37500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 3750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4144;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("40000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_40000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 4000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4721;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("42500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_42500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 4250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5313;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("45000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_45000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 4500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5919;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("47500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_47500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 4750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6541;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("50000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_50000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 5000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7177;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("52500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_52500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 5250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7827;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("55000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_55000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 5500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8492;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("57500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_57500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 5750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9172;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("60000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_60000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 6000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9867;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("62500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_62500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 6250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10591;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("65000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_65000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 6500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11407;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("67500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_67500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 6750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12243;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("70000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_70000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 7000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13097;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("72500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_72500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 7250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13969;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("75000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_75000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 7500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14861;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("77500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_77500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 7750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 15771;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("80000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_80000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 8000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16699;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("82500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_82500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 8250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 17646;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("85000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_85000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 8500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 18598;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("87500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_87500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 8750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 19550;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("90000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_90000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 9000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 20503;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("92500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_92500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 9250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 21529;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("95000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_95000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 9500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 22579;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("97500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_97500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 9750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 23629;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("100000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void I_100000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 1,
                LZZ = 1,
                RE4 = 10000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 24679;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        ///////// STKL2 /////////

        [TestMethod, TestCategory("II"), TestCategory("5.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_5000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("7.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_7500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("10.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_10000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 1000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("12.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_12500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 1250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("15.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_15000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 1500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("17.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_17500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 1750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("20.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_20000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 2000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("22.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_22500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 2250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 169;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("25.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_25000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 2500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 533;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("27.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_27500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 2750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 974;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("30.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_30000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 3000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1466;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("32.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_32500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 3250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1973;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("35.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_35000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 3500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2495;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("37.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_37500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 3750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3032;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("40.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_40000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 4000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3583;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("42.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_42500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 4250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4150;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("45.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_45000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 4500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4732;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("47.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_47500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 4750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5328;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("50.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_50000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 5000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5940;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("52.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_52500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 5250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6566;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("55.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_55000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 5500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7208;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("57.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_57500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 5750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7864;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("60.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_60000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 6000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8535;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("62.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_62500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 6250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9234;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("65.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_65000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 6500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10019;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("67.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_67500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 6750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10822;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("70.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_70000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 7000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11644;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("72.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_72500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 7250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12485;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("75.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_75000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 7500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13344;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("77.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_77500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 7750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14222;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("80.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_80000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 8000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 15119;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("82.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_82500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 8250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16034;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("85.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_85000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 8500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16968;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("87.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_87500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 8750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 17917;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("90.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_90000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 9000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 18870;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("92.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_92500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 9250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 19897;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("95.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_95000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 9500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 20947;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("97.500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_97500_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 9750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 21997;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("100.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 0")]
        public void II_100000_0_0_0()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 10000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 23047;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        ///////// STKL3 /////////

        [TestMethod, TestCategory("III"), TestCategory("5.000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_5000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("7500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_7500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("10000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_10000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 1000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("12500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_12500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 1250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("15000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_15000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 1500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("17500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_17500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 1750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("20000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_20000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 2000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("22500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_22500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 2250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("25000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_25000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 2500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("27500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_27500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 2750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("30000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_30000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 3000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("32500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_32500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 3250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 250;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("35000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_35000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 3500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 584;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("37500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_37500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 3750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 954;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("40000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_40000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 4000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1360;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("42500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_42500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 4250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1804;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("45000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_45000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 4500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2284;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("47500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_47500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 4750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2774;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("50000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_50000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 5000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3270;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("52500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_52500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 5250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3776;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("55000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_55000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 5500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4288;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("57500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_57500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 5750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4806;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("60000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_60000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 6000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5334;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("62500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_62500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 6250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5878;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("65000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_65000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 6500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6488;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("67500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_67500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 6750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7108;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("70000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_70000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 7000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7736;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("72500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_72500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 7250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8374;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("75000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_75000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 7500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9022;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("77500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_77500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 7750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9678;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("80000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_80000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 8000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10346;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("82500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_82500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 8250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11020;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("85000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_85000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 8500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11706;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("87500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_87500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 8750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12400;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("90000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_90000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 9000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13102;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("92500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_92500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 9250000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13872;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("95000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_95000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 9500000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14668;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("97500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_97500_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 9750000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 15478;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("100000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void III_100000_0_0_1()
        {
            par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 3,
                LZZ = 1,
                RE4 = 10000000,
            };
            lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16298;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        ///////// STKL4 /////////

        [TestMethod, TestCategory("IV"), TestCategory("5000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_5000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 500000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("7500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_7500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 750000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("10000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_10000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 1000000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("12500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_12500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 1250000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("15000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_15000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 1500000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("17500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_17500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 1750000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 165;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("20000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_20000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 2000000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 550;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("22500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_22500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 2250000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 990;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("25000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_25000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 2500000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 1478;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("27500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_27500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 2750000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 1982;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("30000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_30000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 3000000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 2501;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("32500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_32500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 3250000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 3033;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("35000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_35000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 3500000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 3581;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("37500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_37500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 3750000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 4144;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("40000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_40000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 4000000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 4721;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("42500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_42500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 4250000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 5313;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("45000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_45000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 4500000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 5919;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("47500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_47500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 4750000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 6541;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("50000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_50000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 5000000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 7177;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("52500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_52500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 5250000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 7827;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("55000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_55000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 5500000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 8492;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("57500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_57500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 5750000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 9172;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("60000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_60000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 6000000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 9867;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("62500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_62500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 6250000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 10591;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("65000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_65000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 6500000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 11407;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("67500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_67500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 6750000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 12243;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("70000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_70000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 7000000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 13097;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("72500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_72500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 7250000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 13969;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("75000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_75000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 7500000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 14861;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("77500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_77500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 7750000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 15771;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("80000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_80000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 8000000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 16699;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("82500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_82500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 8250000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 17646;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("85000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_85000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 8500000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 18598;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("87500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_87500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 8750000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 19550;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("90000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_90000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 9000000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 20503;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("92500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_92500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 9250000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 21529;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("95000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_95000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 9500000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 22579;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("97500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_97500_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 9750000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 23629;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }


        [TestMethod, TestCategory("IV"), TestCategory("100000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void IV_100000_0_0_1()
        {
            var par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 4,
                LZZ = 1,
                RE4 = 10000000
            };
            var lohnsteuerrechner = new Lohnsteuerrechner(par);
            lohnsteuerrechner.LST2024();
            const int erwartet = 24679;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        //////// STKL5 ////////
       
        [TestMethod, TestCategory("V"), TestCategory("5000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_5000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 373; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("7500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_7500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 649; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("10000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_10000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 1000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 924;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("12500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_12500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 1250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1199; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("15000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_15000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 1500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1475; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("17500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_17500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 1750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1778; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("20000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_20000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 2000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2516; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("22500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_22500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 2250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3361;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("25000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_25000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 2500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4207; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("27500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_27500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 2750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5053; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("30000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_30000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 3000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5899; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("32500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_32500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 3250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6686; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("35000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_35000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 3500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7422; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("37500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_37500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 3750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8190; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("40000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_40000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 4000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8986; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("42500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_42500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 4250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9810; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("45000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_45000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 4500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10652; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("47500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_47500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 4750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11498; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("50000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_50000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 5000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12344; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("52500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_52500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 5250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13189; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("55000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_55000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 5500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14035; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("57500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_57500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 5750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14881;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("60000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_60000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 6000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 15727; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("62500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_62500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 6250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16589; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("65000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_65000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 6500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 17542; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("67500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_67500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 6750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 18494; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("70000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_70000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 7000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 19446; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("72500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_72500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 7250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 20399; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("75000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_75000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 7500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 21351; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("77500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_77500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 7750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 22304; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("80000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_80000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 8000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 23256; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("82500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_82500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 8250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 24208; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("85000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_85000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 8500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 25160; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("87500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_87500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 8750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 26113; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("90000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_90000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 9000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 27065; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("92500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_92500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 9250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 28092; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("95000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_95000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 9500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 29142; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("97500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_97500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 9750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 30192; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("100000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void V_100000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 5,
                LZZ = 1,
                RE4 = 10000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 31242; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }
             
        ////////// STKL6 //////////
       
        [TestMethod, TestCategory("VI"), TestCategory("5000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_5000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 550; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("7500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_7500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 826; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("10000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_10000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 1000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1101;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("12500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_12500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 1250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1377; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("15000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_15000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 1500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1652; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("17500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_17500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 1750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2150; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("20000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_20000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 2000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3048; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("22500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_22500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 2250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3893;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("25000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_25000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 2500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4739; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("27500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_27500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 2750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5585;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("30000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_30000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 3000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6420; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("32500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_32500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 3250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7146; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("35000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_35000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 3500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7900;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("37500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_37500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 3750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8686; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("40000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_40000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 4000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9500; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("42500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_42500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 4250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10338;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("45000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_45000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 4500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11184; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("47500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_47500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 4750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12030; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("50000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_50000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 5000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12875; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("52500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_52500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 5250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13721; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("55000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_55000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 5500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14567; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("57500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_57500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 5750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 15413;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("60000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_60000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 6000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16259; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("62500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_62500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 6250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 17121; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("65000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_65000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 6500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 18073; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("67500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_67500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 6750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 19026; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("70000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_70000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 7000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 19978; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("72500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_72500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 7250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 20931; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("75000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_75000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 7500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 21883; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("77500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_77500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 7750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 22835; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("80000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_80000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 8000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 23787; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("82500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_82500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 8250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 24740; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("85000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_85000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 8500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 25692; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("87500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_87500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 8750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 26645; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("90000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_90000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 9000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 27597; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("92500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_92500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 9250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 28624; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("95000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_95000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 9500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 29674; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("97500"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_97500_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 9750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 30724;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("100000"), TestCategory("KRV/PKV = 0"), TestCategory("PVZ = 1")]
        public void VI_100000_0_0_1()
        {
            Parameter par = new Parameter
            {
                KRV = 0,
                PKV = 0,
                KVZ = 1.70,
                PVZ = 1,
                STKL = 6,
                LZZ = 1,
                RE4 = 10000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 31774; 
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        //////// besondere maschinelle Jahreslohnsteuer 2024 ////////

        //////// STKL1 ////////


        [TestMethod, TestCategory("I"), TestCategory("5000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_5000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("7500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_7500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("10000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_10000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 1000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("12500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_12500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 1250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("15000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_15000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 1500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 47;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("17500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_17500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 1750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 450;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("20000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_20000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 2000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 984;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("22500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_22500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 2250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1593;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("25000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_25000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 2500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2225;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("27500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_27500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 2750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2879;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("30000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_30000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 3000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3556;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("32500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_32500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 3250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4256;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("35000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_35000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 3500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4978;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("37500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_37500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 3750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5723;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("40000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_40000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 4000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6490;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("42500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_42500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 4250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7281;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("45000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_45000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 4500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8093;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("47500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_47500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 4750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8929;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("50000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_50000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 5000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9787;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("52500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_52500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 5250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10668;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("55000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_55000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 5500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11571;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("57500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_57500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 5750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12497;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("60000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_60000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 6000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13446;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("62500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_62500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 6250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14418;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("65000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_65000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 6500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 15412;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("67500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_67500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 6750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16428;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("70000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_70000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 7000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 17468;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("72500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_72500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 7250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 18518;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("75000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_75000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 7500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 19568;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("77500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_77500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 7750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 20618;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("80000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_80000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 8000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 21668;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("82500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_82500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 8250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 22718;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("85000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_85000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 8500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 23768;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("87500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_87500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 8750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 24818;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("90000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_90000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 9000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 25868;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("92500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_92500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 9250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 26918;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("95000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_95000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 9500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 27968;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("97500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_97500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 9750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 29018;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("I"), TestCategory("100000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void I_100000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 1,
                LZZ = 1,
                RE4 = 10000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 30068;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        //////// STKL2 //////// 

        [TestMethod, TestCategory("II"), TestCategory("5000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_5000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("7500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_7500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("10000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_10000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 1000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("12500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_12500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 1250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("15000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_15000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 1500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("17500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_17500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 1750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("20000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_20000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 2000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 144;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("22500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_22500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 2250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 596;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("25000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_25000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 2500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1162;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("27500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_27500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 2750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1778;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("30000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_30000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 3000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2416;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("32500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_32500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 3250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3077;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("35000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_35000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 3500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3761;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("37500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_37500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 3750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4467;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("40000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_40000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 4000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5196;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("42500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_42500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 4250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5948;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("45000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_45000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 4500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6722;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("47500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_47500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 4750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7519;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("50000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_50000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 5000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8338;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("52500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_52500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 5250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9181;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("55000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_55000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 5500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10045;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("57500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_57500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 5750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10933;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("60000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_60000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 6000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11843;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("62500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_62500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 6250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12776;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("65000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_65000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 6500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13731;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("67500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_67500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 6750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14709;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("70000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_70000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 7000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 15710;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("72500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_72500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 7250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16734;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("75000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_75000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 7500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 17778;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("77500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_77500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 7750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 18828;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("80000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_80000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 8000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 19878;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("82500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_82500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 8250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 20928;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("85000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_85000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 8500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 21978;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("87500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_87500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 8750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 23028;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("90000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_90000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 9000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 24078;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("92500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_92500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 9250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 25128;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("95000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_95000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 9500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 26178;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("97500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_97500_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 9750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 27228;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("II"), TestCategory("100000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 0"), TestCategory("PKPV = 0")]
        public void II_100000_2_1_0_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 0,
                PKPV = 0,
                STKL = 2,
                LZZ = 1,
                RE4 = 10000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 28278;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        //////// STKL3 ////////


        [TestMethod, TestCategory("III"), TestCategory("5000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_5000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("7500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_7500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("10000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_10000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 1000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("12500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_12500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 1250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("15000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_15000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 1500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("17500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_17500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 1750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("20000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_20000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 2000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("22500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_22500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 2250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("25000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_25000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 2500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("27500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_27500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 2750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("30000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_30000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 3000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 382;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("32500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_32500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 3250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 820;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("35000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_35000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 3500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1314;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("37500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_37500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 3750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1866;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("40000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_40000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 4000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2466;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("42500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_42500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 4250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3078;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("45000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_45000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 4500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3702;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("47500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_47500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 4750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4338;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("50000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_50000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 5000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4984;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("52500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_52500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 5250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5642;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("55000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_55000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 5500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6312;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("57500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_57500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 5750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6992;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("60000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_60000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 6000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7684;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("62500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_62500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 6250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8388;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("65000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_65000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 6500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9102;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("67500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_67500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 6750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9828;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("70000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_70000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 7000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10566;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("72500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_72500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 7250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11314;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("75000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_75000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 7500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12074;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("77500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_77500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 7750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12846;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("80000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_80000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 8000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13628;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("82500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_82500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 8250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14422;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("85000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_85000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 8500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 15228;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("87500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_87500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 8750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16044;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("90000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_90000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 9000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16872;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("92500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_92500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 9250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 17710;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("95000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_95000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 9500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 18562;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("97500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_97500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 9750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 19424;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("III"), TestCategory("100000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void III_100000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 3,
                LZZ = 1,
                RE4 = 10000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 20296;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        //////// STKL4 ////////

        [TestMethod, TestCategory("IV"), TestCategory("5000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_5000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("7500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_7500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("10000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_10000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 1000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("12500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_12500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 1250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 0;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("15000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_15000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 1500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 47;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("17500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_17500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 1750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 450;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("20000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_20000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 2000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 984;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("22500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_22500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 2250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1593;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("25000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_25000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 2500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2225;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("27500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_27500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 2750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2879;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("30000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_30000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 3000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3556;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("32500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_32500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 3250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4256;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("35000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_35000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 3500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4978;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("37500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_37500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 3750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5723;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("40000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_40000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 4000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6490;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("42500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_42500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 4250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7281;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("45000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_45000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 4500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8093;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("47500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_47500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 4750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8929;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("50000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_50000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 5000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9787;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("52500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_52500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 5250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10668;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("55000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_55000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 5500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11571;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("57500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_57500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 5750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12497;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("60000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_60000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 6000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13446;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("62500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_62500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 6250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14418;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("65000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_65000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 6500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 15412;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("67500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_67500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 6750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16428;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("70000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_70000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 7000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 17468;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("72500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_72500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 7250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 18518;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("75000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_75000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 7500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 19568;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("77500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_77500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 7750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 20618;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("80000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_80000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 8000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 21668;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("82500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_82500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 8250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 22718;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("85000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_85000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 8500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 23768;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("87500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_87500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 8750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 24818;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("90000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_90000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 9000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 25868;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("92500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_92500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 9250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 26918;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("95000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_95000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 9500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 27968;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("97500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_97500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 9750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 29018;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("IV"), TestCategory("100000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void IV_100000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 4,
                LZZ = 1,
                RE4 = 10000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 30068;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        //////// STKL5 ////////


        [TestMethod, TestCategory("V"), TestCategory("5000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_5000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 438;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("7500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_7500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 746;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("10000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_10000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 1000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1054;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("12500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_12500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 1250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1362;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("15000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_15000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 1500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1670;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("17500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_17500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 1750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2302;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("20000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_20000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 2000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3352;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("22500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_22500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 2250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4402;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("25000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_25000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 2500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5452;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("27500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_27500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 2750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6480;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("30000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_30000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 3000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7386;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("32500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_32500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 3250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8340;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("35000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_35000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 3500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9342;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("37500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_37500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 3750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10380;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("40000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_40000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 4000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11430;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("42500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_42500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 4250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 12480;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("45000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_45000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 4500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13530;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("47500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_47500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 4750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14580;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("50000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_50000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 5000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 15630;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("52500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_52500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 5250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16680;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("55000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_55000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 5500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 17730;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("57500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_57500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 5750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 18780;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("60000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_60000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 6000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 19830;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("62500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_62500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 6250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 20880;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("65000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_65000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 6500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 21930;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("67500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_67500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 6750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 22980;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("70000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_70000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 7000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 24030;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("72500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_72500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 7250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 25080;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("75000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_75000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 7500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 26130;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("77500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_77500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 7750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 27180;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("80000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_80000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 8000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 28230;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("82500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_82500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 8250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 29280;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("85000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_85000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 8500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 30330;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("87500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_87500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 8750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 31380;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("90000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_90000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 9000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 32430;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("92500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_92500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 9250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 33480;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("95000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_95000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 9500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 34530;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("97500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_97500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 9750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 35580;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("V"), TestCategory("100000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void V_100000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 5,
                LZZ = 1,
                RE4 = 10000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 36630;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        //////// STKL6 ////////

        [TestMethod, TestCategory("VI"), TestCategory("5000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_5000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 616;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("7500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_7500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 924;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("10000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_10000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 1000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1232;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("12500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_12500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 1250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1540;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("15000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_15000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 1500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 1848;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("17500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_17500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 1750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 2833;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("20000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_20000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 2000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 3883;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("22500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_22500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 2250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 4933;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("25000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_25000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 2500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 5983;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("27500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_27500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 2750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 6934;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("30000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_30000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 3000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 7866;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("32500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_32500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 3250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 8842;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("35000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_35000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 3500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 9864;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("37500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_37500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 3750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 10912;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("40000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_40000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 4000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 11962;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("42500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_42500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 4250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 13012;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("45000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_45000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 4500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 14062;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("47500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_47500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 4750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 15112;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("50000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_50000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 5000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 16162;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("52500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_52500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 5250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 17212;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("55000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_55000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 5500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 18262;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("57500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_57500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 5750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 19312;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("60000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_60000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 6000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 20362;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("62500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_62500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 6250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 21412;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("65000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_65000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 6500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 22462;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("67500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_67500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 6750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 23512;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("70000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_70000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 7000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 24562;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("72500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_72500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 7250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 25612;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("75000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_75000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 7500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 26662;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("77500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_77500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 7750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 27712;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("80000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_80000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 8000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 28762;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("82500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_82500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 8250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 29812;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("85000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_85000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 8500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 30862;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("87500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_87500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 8750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 31912;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("90000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_90000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 9000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 32962;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("92500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_92500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 9250000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 34012;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("95000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_95000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 9500000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 35062;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("97500"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_97500_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 9750000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 36112;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }

        [TestMethod, TestCategory("VI"), TestCategory("100000"), TestCategory("KRV=2, PKV=1"), TestCategory("PVZ = 1"), TestCategory("PKPV = 0")]
        public void VI_100000_2_1_1_0()
        {
            Parameter par = new Parameter
            {
                KRV = 2,
                PKV = 1,
                KVZ = 1.70,
                PVZ = 1,
                PKPV = 0,
                STKL = 6,
                LZZ = 1,
                RE4 = 10000000,
            };
            Lohnsteuerrechner lohnsteuerrechner = new Lohnsteuerrechner(par);

            lohnsteuerrechner.LST2024();

            const int erwartet = 37162;
            Assert.AreEqual(erwartet, par.LSTJAHR);
        }
    }
}