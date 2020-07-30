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

        public static BartlettStatsResults BartlettStats(String csvPath)
        {
            REngine engine;
            //init the R engine            
            engine = getInststance();

            //executing script
            engine.Evaluate("data <- read.csv('C:/Users/ISLEM/Desktop/Sheet.csv', sep = ';')\n" +
                "R <- cor(data)\n" +
                "n <- nrow(data)\n" +
                "p <- ncol(data)\n" +
                "chi2 <- -(n-1-(2*p+5)/6)*log(det(R))\n" +
                "ddl <- p*(p-1)/2\n" +
                "pch <- pchisq(chi2,ddl,lower.tail=F)");

            BartlettStatsResults results = new BartlettStatsResults();
            results.chi2 = Double.Parse(engine.GetSymbol("chi2").AsCharacter()[0], CultureInfo.InvariantCulture);
            results.ddl = Double.Parse(engine.GetSymbol("ddl").AsCharacter()[0], CultureInfo.InvariantCulture);
            results.pch = Double.Parse(engine.GetSymbol("pch").AsCharacter()[0], CultureInfo.InvariantCulture);

            Clear();
            return results;
        }

        public static double KMOStats(String csvPath)
        {
            REngine engine;
            //init the R engine            
            engine = getInststance();

            //executing script
            engine.Evaluate("data <- read.csv('C:/Users/ISLEM/Desktop/Sheet.csv', sep = ';')\n" +
                "R <- cor(data)\n" +
                "A <- solve(R)\n" +
                "kmo.num <- sum(R^2) - sum(diag(R^2))\n" +
                "kmo.denom <- kmo.num + (sum(A^2) - sum(diag(A^2)))\n" +
                "kmo <- kmo.num/kmo.denom");

            double kmo = Double.Parse(engine.GetSymbol("kmo").AsCharacter()[0], CultureInfo.InvariantCulture);

            Clear();
            return kmo;
        }

        public static void PCA(String csvPath)
        {
            REngine engine;
            //init the R engine            
            engine = getInststance();

            //executing script
            engine.Evaluate("data <- read.csv('C:/Users/ISLEM/Desktop/Sheet.csv', sep = ';')\n" +
                "pca <- princomp(data, cor=T)\n" +
                "part <- pca$sdev^2/sum(pca$sdev^2)*100\n" +
                "biplot(pca)");

            Clear();
        }
    }
}
