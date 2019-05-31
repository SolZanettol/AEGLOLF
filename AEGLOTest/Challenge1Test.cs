using Microsoft.VisualStudio.TestTools.UnitTesting;
using n;
using TestStack.BDDfy;
using System.Linq;

namespace AEGLOTest
{
    [Story(
        AsA = "As a poète amateur",
        IWant = "I want intégrer un mot dans un autre",
        SoThat = "So that mon Tumblr devienne famous")]

    [TestClass]
    public class LesMotsContiennentDesMajuscules
    {
        private string contenant, contenu;
        private A challenge1 = new A();
        private string resultat;

        [Given(StepTitle = "Supposons que les deux mots contiennent des majuscules")]
        void GivenLesMotsContiennentDesMajuscules()
        {
            (contenant, contenu) = ("ShE BelieveD", "He LiEd");
        }

        [When(StepTitle = "Lorsque j'appelle la fonction du Challenge 1 sur mon contenant et mon contenu")]
        void WhenLaFonctionEstAppelee()
        {
            resultat = challenge1.a(contenant,contenu);
        }

        [Then(StepTitle = "Alors la capitalisation du contenant est conservée")]
        void AlorsLaCapitalisationDuContenantEstConservee()
        {
            Assert.AreEqual("SEBD", resultat[0].ToString() + resultat[3].ToString() + 
                resultat[6].ToString() + resultat[16].ToString());
        }

        [AndThen(StepTitle = "Et la capitalisation du contenu est ignorée")]
        void EtLaCapitalisationDuContenuEstIgnoree()
        {
            Assert.AreEqual("hle", resultat[2].ToString() + resultat[9].ToString() + resultat[11].ToString());
        }

        [AndThen(StepTitle = "Et le contenu est intégré au contenant")]
        void EtLeContenuEstIntégréAuContenant()
        {
            Assert.AreEqual("S[hE] Be[lie]ve[D]", resultat);
        }

        [TestMethod]
        public void Execute()
        {
            this.BDDfy();
        }
    }
    [Story(
        AsA = "As a poète amateur",
        IWant = "I want intégrer un mot dans un autre",
        SoThat = "So that mon Tumblr devienne famous")]
    [TestClass]
    public class LeMotContenuComprendDesEspaces
    {
        private string contenant, contenu;
        private A challenge1 = new A();
        private string resultat;

        [Given(StepTitle = "Supposons qu'il y a des espaces dans le mot contenu")]
        void GivenLesMotsContiennentDesMajuscules()
        {
            (contenant, contenu) = ("Salut la gang? Salut la gang!", "G u l a g");
        }

        [When(StepTitle = "Lorsque j'appelle la fonction du Challenge 1 sur mon contenant et mon contenu")]
        void WhenLaFonctionEstAppelee()
        {
            resultat = challenge1.a(contenant, contenu);
        }

        [Then(StepTitle = "Alors les espaces du mot contenu sont ignorés")]
        void AlorsLesEspacesDuMotContenuSontIgnores()
        {
            Assert.AreEqual(5, resultat.Count(c => c == ' ')); /*Vérifie que le nombre d'espace est
                                                                le même que dans le contenant*/
        }

        [AndThen(StepTitle = "Et le contenu est intégré au contenant")]
        void EtLeContenuEstIntegreAuContenant()
        {
            Assert.AreEqual("Salut la [g]ang? Sal[u]t [la] [g]ang!", resultat);
        }

        [TestMethod]
        public void Execute()
        {
            this.BDDfy();
        }
    }
}

