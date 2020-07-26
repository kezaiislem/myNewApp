using RDotNet;
using System;
using System.Collections.Generic;
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
            if(instance == null)
            {
                REngine.SetEnvironmentVariables();
                instance = REngine.GetInstance();
                instance.Initialize();
            }
            return instance;
        }

        public static void Clear()
        {
            if(instance != null)
            {
                instance.ClearGlobalEnvironment();
            }
        }

        public static void test(string expression)
        {
            string result;
            REngine engine;

            //init the R engine            
            engine = getInststance();

            //calculate
            CharacterVector vector = engine.Evaluate(expression).AsCharacter();
            result = vector[0];

            //Clear
            Clear();

            //output
            Console.WriteLine("");
            Console.WriteLine("Result: '{0}'", result);
        }
    }
}
