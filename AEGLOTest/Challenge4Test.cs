using Microsoft.VisualStudio.TestTools.UnitTesting;
using n;
using System.Collections.Generic;
using TestStack.BDDfy;

namespace AEGLOTest
{
    [Story(
        AsA = "As a fier Polonais",
        IWant = "I want transformer des expressions utilisant des opérateurs infixes en notation polonaise inverse",
        SoThat = "So that rendre mes calculs clairs et sans ambiguïté")]

    [TestClass]
    public class DesExpressionsInfixes
    {
        private List<string> arguments;
        private List<string> resultats = new List<string> { };
        private D challenge4 = new D();

        [Given(StepTitle = "Supposons que j'ai des expressions infixes")]
        void JaiDesExpressionsInfixes()
        {
            arguments = new List<string>
                    {
                        "(3 * 4) * 2 + 1",
                        "(5 - 6) * 2 / (1 + 3)",
                        "(4 - 1) / (2 - 3)",
                        "((5 - 3) * ((4 / 2 - 1) * 2))",
                        "(4 ^ 2) * 3",
                        "4 ^ (3 - 1)"
                    };
        }

        [When(StepTitle = "Lorsque j'appelle la fonction du Challenge 4 sur ces expressions")]
        void WhenLaFonctionEstAppelee()
        {
            foreach (string argument in arguments)
            {
                resultats.Add(challenge4.d(argument));
            }
        }

        [Then(StepTitle = "Alors le résultat est en notation polonaise inverse")]
        void AlorsLeResultatEstEnNotationPolonaiseInverse()
        {
            CollectionAssert.AreEqual(new string[]
            {
                        new string("3 4 * 2 * 1 +".ToCharArray()),
                        new string("5 6 - 2 * 1 3 + /".ToCharArray()),
                        new string("4 1 - 2 3 - /".ToCharArray()),
                        new string("5 3 - 4 2 / 1 - 2 * *".ToCharArray()),
                        new string("4 2 ^ 3 *".ToCharArray()),
                        new string("4 3 1 - ^".ToCharArray())
            }, resultats);
        }

        [TestMethod]
        public void Execute()
        {
            this.BDDfy();
        }
    }
}
