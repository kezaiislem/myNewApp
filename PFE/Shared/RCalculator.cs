using PFE.CustomObjects;
using RDotNet;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Shared
{
    class RCalculator
    {
        private static REngine instance { get; set; }

        public static REngine getInststance()
        {
            if (instance == null)
            {
                REngine.SetEnvironmentVariables();
                instance = REngine.GetInstance();
                instance.Initialize();
            }
            return instance;
        }

        public static void Clear()
        {
            if (instance != null)
            {
                instance.ClearGlobalEnvironment();
            }
        }

        public static void InstallPackages()
        {

        }

        public static SphericityTestResults SphericityTest(String csvPath)
        {
            try
            {
                REngine engine;
                //init the R engine            
                engine = getInststance();

                csvPath = csvPath.Replace('\\', '/');

                //executing script
                engine.Evaluate("library(psych)\n" +
                    "data <- read.csv('" + csvPath + "', sep = ';')\n" +
                    "R <- cor(data, method = 'pearson')\n" +
                    "kmo <- KMO(R)\n" +
                    "kmov <- kmo$MSA\n" +
                    "bartlett <- cortest.bartlett(R)\n" +
                    "bartlettv <- bartlett$p.value");

                SphericityTestResults results = new SphericityTestResults();
                results.kmo = Double.Parse(engine.GetSymbol("kmov").AsCharacter()[0], CultureInfo.InvariantCulture);
                results.bartlett = Double.Parse(engine.GetSymbol("bartlettv").AsCharacter()[0], CultureInfo.InvariantCulture);

                Clear();
                return results;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public static void plotPCALoadings(String csvPath)
        {
            try
            {
                REngine engine;
                //init the R engine            
                engine = getInststance();

                csvPath = csvPath.Replace('\\', '/');

                //executing script
                engine.Evaluate("library(psych)\n" +
                    "data <- read.csv('" + csvPath + "', sep = ';')\n" +
                    "pca <- principal(data, 2, rotate='varimax')\n" +
                    "biplot(pca)");

                Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        
        public static void plotPrincipalCompnnents(String csvPath)
        {
            try
            {
                REngine engine;
                //init the R engine            
                engine = getInststance();

                csvPath = csvPath.Replace('\\', '/');

                //executing script
                engine.Evaluate("library(psych)\n" +
                    "data <- read.csv('" + csvPath + "', sep = ';')\n" +
                    "pca <- principal(data, 2, rotate='varimax')\n" +
                    "plot(pca$values, type = 'o', xlab = 'Components', ylab = 'Values')");

                Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static PCAResults PCA(String csvPath, int numberOfFactors)
        {
            try
            {
                REngine engine;
                //init the R engine            
                engine = getInststance();

                csvPath = csvPath.Replace('\\', '/');

                //executing script
                engine.Evaluate("library(psych)\n" +
                    "data <- read.csv('" + csvPath + "', sep = ';')\n" +
                    "pca <- principal(data, "+ numberOfFactors +", rotate='varimax')\n" +
                    "pcaTable <- as.data.frame.matrix(rbind(pca$values, pca$values/sum(pca$values)*100, cumsum(pca$values), cumsum(pca$values/sum(pca$values)*100)))\n" +
                    "loadings <- as.data.frame.matrix(t(pca$loadings))");

                PCAResults pCAResults = new PCAResults();
                pCAResults.pcaTable = engine.GetSymbol("pcaTable").AsDataFrame();
                pCAResults.loadings = engine.GetSymbol("loadings").AsDataFrame();

                Clear();
                return pCAResults;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }

        }

        public static void showCorelationTable(String csvPath)
        {
            try
            {
                REngine engine;
                //init the R engine            
                engine = getInststance();

                csvPath = csvPath.Replace('\\', '/');

                //executing script
                engine.Evaluate("data <- read.csv('" + csvPath + "', sep = ';')\n" +
                    "R <- cor(data)\n " +
                    "library(gridExtra)\n " +
                    "library(grid)\n " +
                    "grid.table(R)");

                Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static double CalculateAlpha(String csvPath)
        {
            try
            {
                REngine engine;
                //init the R engine            
                engine = getInststance();

                csvPath = csvPath.Replace('\\', '/');

                //executing script
                engine.Evaluate("library(psych)\n" +
                    "data <- read.csv('" + csvPath + "', sep = ';')\n" +
                    "x <- alpha(data, check.keys=TRUE)\n" +
                    "ca <- x[['total']][['raw_alpha']]");

                double alpha = Double.Parse(engine.GetSymbol("ca").AsCharacter()[0], CultureInfo.InvariantCulture);

                Clear();
                return alpha;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return -1;
            }
        }
    }
}
