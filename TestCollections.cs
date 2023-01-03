using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__lab11
{
    public class TestCollections
    {
        public Stack<Engine> Collection1 = new Stack<Engine>();                                                               //Коллекция_1<TKey> ; 
        public Stack<string> Collection2 = new Stack<string>();                                                               //Коллекция_1<string> ; 
        public Dictionary<Engine, InternalCombustionEngine> Collection3 = new Dictionary<Engine, InternalCombustionEngine>(); //Коллекция_2<TKey, TValue> ; 
        public Dictionary<string, InternalCombustionEngine> Collection4 = new Dictionary<string, InternalCombustionEngine>(); //Коллекция_2<string, TValue>.

        public TestCollections(int size)
        {
            for (int i = 0; i < size; ++i)
            {
                var InternalCombustionEngine = new InternalCombustionEngine(i, i);
                string strKey = InternalCombustionEngine.BaseEngine.ToString();
                Collection1.Push(InternalCombustionEngine.BaseEngine);
                Collection2.Push(strKey);
                Collection3.Add(InternalCombustionEngine.BaseEngine, InternalCombustionEngine);
                Collection4.Add(strKey, InternalCombustionEngine);
            }
        }
    }
}
