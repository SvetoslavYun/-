using System;

namespace Progekt_1
{
    class Pet
    {
        public string name;
        private int age;
        private double weight;
        private int[] marks = new int[4];

        public int Age
        { get
            {
                return age;
            }
            set
            {
                if (value >= 0 & value < 300)
                    age = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value >= 0 & value < 1000) ;
                weight = value;
            }
        }

        public int[] Marks
        {
            get
            {
                return marks;
            }
            set
            {
                marks.Initialize();
                int i = 0;
                foreach (int m in value)
                {
                    marks[i] = m;
                    i++;
                    if (i >= 4) break;
                }
            }
        }

        public Pet(string Name, int Age, double Weight, int []Marks) 
        {
            name = Name;
            age = Age;
            weight = Weight;
            marks = Marks;
        }

        public override string ToString()
        {
            return String.Format("Питомец по имени {0}, ему {1} лет, весит {2}, оценки: {3},{4},{5},{6}", name, age, weight, marks[0], marks[1], marks[2], marks[3]);
        }
    }
}
