using Microsoft.VisualStudio.TestTools.UnitTesting;
using n;
using TestStack.BDDfy;

namespace AEGLOTest
{
    [Story(
        AsA = "As a spécialiste des arrays",
        IWant = "I want ordonner des arrays selon la somme de leurs éléments, puis ordonner les éléments en ordre croissant dans chaque array",
        SoThat = "So that recréer le principe du TimeSort")]

    [TestClass]
    public class HelloWorldDansUnCadre
    {
        private string argument;
        private string resultat;
        private B challenge2 = new B();

        [Given(StepTitle = "Supposons que j'ai une phrase")]
        void GivenJaiUnePhrase()
        {
            argument = "Hello World in a frame";
        }

        [When(StepTitle = "Lorsque j'appelle la fonction du Challenge 2 sur cette phrase")]
        void WhenLaFonctionEstAppelee()
        {
            resultat = challenge2.b(argument);
        }

        [Then(StepTitle = "Alors la phrase est retournée dans un cadre optimisé")]
        void AlorsLaPhraseEstDansUnCadreOptimise()
        {
            Assert.AreEqual("*********\n* Hello *\n* World *\n* in a  *\n* frame *\n*********", resultat);
        }

        [TestMethod]
        public void Execute()
        {
            this.BDDfy();
        }
    }
}
