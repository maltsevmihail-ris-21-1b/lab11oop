using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__lab11
{
    //15)	двигатель, двигатель внутреннего сгорания, дизель, турбореактивный двигатель;
    public class Engine 
    {
        public int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public Engine() 
        {
            Weight = 0;
        }
        public Engine(int weight)
        {
            Weight = weight;
        }
        public Engine(Engine engine)
        {
            this.weight = engine.weight;
        }
        public override string ToString()
        {
            return "Weight: " + weight.ToString();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Engine temp)
                return (this.Weight).Equals(temp.Weight);
            return false;
        }

        public override int GetHashCode()
        {
            return Weight.GetHashCode();
        }
    }

    public class InternalCombustionEngine : Engine
    {
        protected int cost;
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public Engine BaseEngine
        {
            get { return new Engine(Weight); }
        }
        public InternalCombustionEngine(int _weight, int _cost) : base(_weight)
        {
            cost = _cost;
        }
        public InternalCombustionEngine() : base()
        {
            cost = 0; 
        }

        public InternalCombustionEngine(InternalCombustionEngine _engine) : base(_engine)
        {
            cost= _engine.cost;
        }
        public override string ToString()
        {
            return base.ToString() + ", cost - " + cost.ToString();
        }
    }
}
