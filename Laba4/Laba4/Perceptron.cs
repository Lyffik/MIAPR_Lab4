using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laba4
{
    public class Perceptron
    {
        private const int C = 1;
        private const int RANDOM = 20;
        private readonly int attributesCount;
        private readonly List<PerceptronClass> classes = new List<PerceptronClass>();
        private readonly int classesCount;
        private readonly List<int> decisions = new List<int>();
        private readonly int objectsInClassCount;
        private readonly List<PerceptronObject> weigths = new List<PerceptronObject>();
        private List<PerceptronObject> decisionFunctions;

        public Perceptron(int classes, int objectsInclass, int attribute)
        {
            classesCount = classes;
            objectsInClassCount = objectsInclass;
            attributesCount = attribute;
        }

        /* public void SetClasess(List<PerceptronClass> perceptronClasses)
        {
            classes.Clear();
            weigths.Clear();
            decisionFunctions.Clear();
            classes = perceptronClasses;
            classesCount = classes.Count;
            objectsInClassCount = classes[0].objects.Count;
            attributesCount = classes[0].objects[0].attributes.Count;
            foreach (PerceptronClass perceptronClass in classes)
            {
                var weigth = new PerceptronObject();
                for (int i = 0; i <= attributesCount; i++)
                {
                    weigth.attributes.Add(0);
                }
                weigths.Add(weigth);
                decisions.Add(0);
            }
            SupplementObjects(classes);
        }*/

        private void SupplementObjects(List<PerceptronClass> perceptronClasses)
        {
            foreach (PerceptronClass perceptronClass in perceptronClasses)
            {
                foreach (PerceptronObject perceptronObject in perceptronClass.objects)
                {
                    perceptronObject.attributes.Add(1);
                }
            }
        }

        private void CreateTestClasses()
        {
            for (int i = 0; i < classesCount; i++)
            {
                var currClass = new PerceptronClass();
                for (int j = 0; j < objectsInClassCount; j++)
                {
                    var currObject = new PerceptronObject();
                    for (int k = 0; k < attributesCount; k++)
                    {
                        currObject.attributes.Add(0);
                    }
                    currClass.objects.Add(currObject);
                }
                classes.Add(currClass);
            }
            foreach (PerceptronClass perceptronClass in classes)
            {
                var weigth = new PerceptronObject();
                for (int i = 0; i <= attributesCount; i++)
                {
                    weigth.attributes.Add(0);
                }
                weigths.Add(weigth);
                decisions.Add(0);
            }
            classes[0].objects[0].attributes[0] = 0;
            classes[0].objects[0].attributes[1] = 0;
            classes[1].objects[0].attributes[0] = 1;
            classes[1].objects[0].attributes[1] = 1;
            classes[2].objects[0].attributes[0] = -1;
            classes[2].objects[0].attributes[1] = 1;
            SupplementObjects(classes);
        }

        private void CreateRandomClasses()
        {
            var rnd = new Random();
            for (int i = 0; i < classesCount; i++)
            {
                var currClass = new PerceptronClass();
                for (int j = 0; j < objectsInClassCount; j++)
                {
                    var currObject = new PerceptronObject();
                    for (int k = 0; k < attributesCount; k++)
                    {
                        currObject.attributes.Add(rnd.Next(RANDOM) - 10);
                    }
                    currClass.objects.Add(currObject);
                }
                classes.Add(currClass);
            }
            foreach (PerceptronClass perceptronClass in classes)
            {
                var weigth = new PerceptronObject();
                for (int i = 0; i <= attributesCount; i++)
                {
                    weigth.attributes.Add(0);
                }
                weigths.Add(weigth);
                decisions.Add(0);
            }
            SupplementObjects(classes);
        }

        private int ObjectMultiplication(PerceptronObject weigth, PerceptronObject obj)
        {
            int result = 0;
            for (int i = 0; i < weigth.attributes.Count; i++)
            {
                result += weigth.attributes[i]*obj.attributes[i];
            }
            return result;
        }

        private void ChangeWeigth(PerceptronObject weigth, PerceptronObject perceptronObject, int sign)
        {
            for (int i = 0; i < weigth.attributes.Count; i++)
            {
                weigth.attributes[i] += sign*perceptronObject.attributes[i];
            }
        }

        private bool CorrectWeigth(PerceptronClass currClass, PerceptronObject currObject, PerceptronObject currWeigth,
            int classNumber)
        {
            bool result = false;
            int objD = ObjectMultiplication(currWeigth, currObject);
            for (int i = 0; i < weigths.Count; i++)
            {
                decisions[i] = ObjectMultiplication(weigths[i], currObject);

                if (i != classNumber)
                {
                    int currD = decisions[i];
                    if (objD <= currD)
                    {
                        ChangeWeigth(weigths[i], currObject, -1);
                        result = true;
                    }
                }
            }
            if (result)
            {
                ChangeWeigth(currWeigth, currObject, 1);
            }
            return result;
        }

        private void CalculateDecisionFunctions()
        {
            bool IsMisclassification = true;
            int iteration = 0;
            while (IsMisclassification && iteration < 10000)
            {
                for (int i = 0; i < classes.Count; i++)
                {
                    PerceptronClass currClass = classes[i];
                    PerceptronObject currWeigth = weigths[i];
                    for (int j = 0; j < currClass.objects.Count; j++)
                    {
                        PerceptronObject currObject = currClass.objects[j];
                        IsMisclassification = CorrectWeigth(currClass, currObject, currWeigth, i);
                    }
                }
                iteration++;
            }
            if (iteration == 1000)
            {
                MessageBox.Show("Количество итеррация превысило 10000!");
            }
            decisionFunctions = weigths;
        }

        private bool CheckIsCorrectness()
        {
            bool result = true;
            for (int i = 0; i < classes.Count; i++)
            {
                foreach (PerceptronObject currObject in classes[i].objects)
                {
                    int objD = ObjectMultiplication(weigths[i], currObject);
                    int maxD = objD;
                    foreach (PerceptronObject perceptronObject in decisionFunctions)
                    {
                        if (ObjectMultiplication(decisionFunctions[i], currObject) > maxD)
                        {
                            maxD = ObjectMultiplication(decisionFunctions[i], currObject);
                        }
                    }
                    if (maxD > objD)
                    {
                        result = false;
                        return result;
                    }
                }
            }
            return result;
        }

        public void FillListBox(ListBox listBoxClasses, ListBox listBoxFunc)
        {
            listBoxClasses.Items.Clear();
            listBoxFunc.Items.Clear();
            int curr = 1;
            foreach (PerceptronClass currClass in classes)
            {
                listBoxClasses.Items.Add("");
                listBoxClasses.Items.Add(String.Format("Класс {0}:", curr));
                int i = 1;
                foreach (PerceptronObject currObj in currClass.objects)
                {
                    string str = String.Format("    Объект {0}: (", i);
                    for (int j = 0; j < currObj.attributes.Count - 1; j++)
                    {
                        int attribute = currObj.attributes[j];
                        str += attribute + "; ";
                    }
                    str = str.Remove(str.Length - 2, 2);
                    str += ")";
                    listBoxClasses.Items.Add(str);
                    i++;
                }
                curr++;
            }
            listBoxFunc.Items.Add("Решающие функции: ");
            for (int i = 0; i < decisionFunctions.Count; i++)
            {
                string str;
                str = String.Format("d{0}(X): ", i + 1);
                for (int j = 0; j < decisionFunctions[i].attributes.Count; j++)
                {
                    int attribute = decisionFunctions[i].attributes[j];
                    if (j < decisionFunctions[i].attributes.Count - 1)
                    {
                        if (attribute >= 0 && j != 0)
                        {
                            str += "+" + attribute + String.Format("*X{0}", j + 1);
                        }
                        else
                        {
                            str += attribute + String.Format("*X{0}", j + 1);
                        }
                    }
                    else
                    {
                        if (attribute >= 0 && j != 0)
                        {
                            str += "+" + attribute;
                        }
                        else
                        {
                            str += attribute;
                        }
                    }
                }
                listBoxFunc.Items.Add(str);
            }
        }

        public int FindClass(PerceptronObject perceptronObject)
        {
            int result = 0;
            perceptronObject.attributes.Add(1);
            int dMax = ObjectMultiplication(weigths[0], perceptronObject);
            for (int i = 1; i < weigths.Count; i++)
            {
                PerceptronObject weigth = weigths[i];
                if (ObjectMultiplication(weigth, perceptronObject) > dMax)
                {
                    dMax = ObjectMultiplication(weigth, perceptronObject);
                    result = i;
                }
            }
            return result + 1;
        }

        public void Calculate()
        {
            CreateRandomClasses();
            //   CreateTestClasses();
            CalculateDecisionFunctions();
            if (CheckIsCorrectness() == false)
            {
                MessageBox.Show("Решающие функции некорректны!");
            }
        }

        public class PerceptronClass
        {
            public readonly List<PerceptronObject> objects = new List<PerceptronObject>();
        }

        public class PerceptronObject
        {
            public readonly List<int> attributes = new List<int>();
        }
    }
}