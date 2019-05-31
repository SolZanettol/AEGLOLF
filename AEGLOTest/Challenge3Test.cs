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
    public class ArrayDArraysDEntiers
    {
        private int[][] argument;
        private int[][] resultat;
        private C challenge3 = new C();

        [Given(StepTitle = "Supposons que j'ai un array d'arrays d'entiers")]
        void JaiUnArrayDArraysDEntiers()
        {
            argument = new int[][]
                    {
                        new int[] { 2,4,1 },
                        new int[] { 3,1,2 },
                        new int[] { 1,1,1 },
                        new int[] { 2,3,3 }
                    };
        }

        [When(StepTitle = "Lorsque j'appelle la fonction du Challenge 3 sur cet array")]
        void WhenLaFonctionEstAppelee()
        {
            resultat = challenge3.c(argument);
        }

        [Then(StepTitle = "Alors le résultat est ordonné")]
        void AlorsLeResultatEstOrdonne()
        {
            for (int i = 0; i < 4; i++)
            {
                CollectionAssert.AreEqual(
                    new int[][]
                    {
                        new int[] { 1,1,1 },
                        new int[] { 1,2,3 },
                        new int[] { 1,2,4},
                        new int[] { 2,3,3 }
                    }[i],
                    resultat[i]
                    );
            }
        }

        [TestMethod]
        public void Execute()
        {
            this.BDDfy();
        }
    }
}
