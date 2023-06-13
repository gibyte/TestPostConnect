using NUnit.Framework;

namespace TestPostConnect.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {}
        
        [Test]
        public void ValidGC()
        {
            var req = new Model.Request()
            {
                Version = "1.1",
                Method = "approve_card",
                Params = new Model.Params() 
                {
                    Art_barcode = "2000018472224",
                    Wscode = "900001",
                    Barcode = "CT01DC0050045E81"
                }
            };
            var ansver = new Model.Answer(req);
            if (ansver != null && ansver.Result != null) 
            {
                Assert.IsTrue(ansver.Result.Result);
                return;
            }
            Assert.Fail();
        }

        [Test]
        public void NotValidGC()
        {
            var req = new Model.Request()
            {
                Version = "1.1",
                Method = "approve_card",
                Params = new Model.Params()
                {
                    Art_barcode = "2000018472224",
                    Wscode = "900001",
                    Barcode = "CT01DC0050045E80"
                }
            };
            var ansver = new Model.Answer(req);
            if (ansver != null && ansver.Result != null)
            {
                Assert.IsFalse(ansver.Result.Result);
                return;
            }
            Assert.Fail();
        }

        [Test]
        public void InfoGC()
        {
            var req = new Model.Request()
            {
                Version = "1.1",
                Method = "get_info",
                Params = new Model.Params{
                    User = "cashier",
                    Password = "0",
                    Wscode = "900001",
                    Card_num = "01DC0050045E",
                    Ribbon_width = 45, // необязательный параметр
                    Org_division = "Магнит МК Плед" 
                }
            };
            var ansver = new Model.Answer(req);
            if (ansver != null && ansver.Result != null)
            {
                Assert.IsTrue(ansver.Result.Result);
                return;
            }
            Assert.Fail();
        }

        [Test]
        public void ActivateGC()
        {
            var req = new Model.Request()
            {
                Version = "1.1",
                Method = "activate",
                Params = new Model.Params()
                {
                    User  = "cashier",
                    Password = "0",
                    Wscode = "900001",
                    Card_num = "01DC0050045E",
                    Opguid = "034B8166F54911ED9C9950AF73396779",
                    Opdate = new Model.Datetime() { __datetime = "20230518T095555"},
                    Artcode = "77710000"
                }
            };
            var ansver = new Model.Answer(req);
            if (ansver != null && ansver.Result != null)
            {
                Assert.IsTrue(ansver.Result.Result);
                return;
            }
            Assert.Fail();
        }

        [Test]
        public void ActivateNotCorrectGC()
        {
            var req = new Model.Request()
            {
                Version = "1.1",
                Method = "activate",
                Params = new Model.Params()
                {
                    User = "cashier",
                    Password = "0",
                    Wscode = "900001",
                    Card_num = "01DC7750045E",
                    Opguid = "034B8166F54911ED9C9950AF73396779",
                    Opdate = new Model.Datetime() { __datetime = "20230518T095555" },
                    Artcode = "1000263892"
                }
            };
            var ansver = new Model.Answer(req);
            if (ansver != null && ansver.Result != null)
            {
                Assert.IsFalse(ansver.Result.Result);
                return;
            }
            Assert.Fail();
        }

            [Test]
        public void DeactivateGC()
        {
            var req = new Model.Request()
            {
                Version = "1.1",
                Method = "deactivate",
                Params = new Model.Params()
                {
                    User = "cashier",
                    Password = "0",
                    Wscode = "900001",
                    Card_num = "01DC0050045E",
                    Opguid = "034B8166F54911ED9C9950AF73396779",
                    Opdate = new Model.Datetime() { __datetime = "20230518T095555" },
                    Artcode = "1000263892"
                }
            };
            var ansver = new Model.Answer(req);
            if (ansver != null && ansver.Result != null)
            {
                Assert.IsFalse(ansver.Result.Result);
                return;
            }
            Assert.Fail();
        }
        
        [Test]
        public void PaymentGC()
        {
            var req = new Model.Request()
            {
                Version = "1.1",
                Method = "payment",
                Params = new Model.Params()
                {
                    User = "cashier",
                    Password = "0",
                    Wscode = "900001",
                    Paysum = 500.0,
                    Opguid = "01FE97E6F94811ED4698207C14F03499",
                    Opdate = new Model.Datetime{ __datetime = "20230523T120038"},
                    Ribbon_width = 45,
                    Org_division = "Магнит МК Плед",
                    Card_num = "01DC7750045E"
                }
            };
            var ansver = new Model.Answer(req);
            if (ansver != null && ansver.Result != null)
            {
                Assert.IsFalse(ansver.Result.Result);
                return;
            }
            Assert.Fail();
        }
    }
}