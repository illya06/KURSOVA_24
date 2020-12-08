using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace KURSOVA_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //_____________________________________
        //GLOBAL VARIABLES

        Car[] list = new Car[0];
        HashSet<string> Marks = new HashSet<string>();
        bool[] hasBoth = new bool[0];

        //_____________________________________
        //FUNCTIONS

        void CarToGrid(Car obj)
        {
            if (!obj.isEmpty)
                dataGridView1.Rows.Add(obj.Mark, obj.CarType, obj.Power, obj.FuelTankSize, obj.FuelPerKm);
            else
                MessageBox.Show("Object is empty!");
        }
        void CarToGrid_2(Car obj)
        {
            if (!obj.isEmpty)
                dataGridView2.Rows.Add(obj.Mark, obj.CarType, obj.Power, obj.FuelTankSize, obj.FuelPerKm);
            else
                MessageBox.Show("Object is empty!");
        }

        void serialize(Car data)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\illyich_\Desktop\car.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(JsonConvert.SerializeObject(data));
            }
        }

        void deserialize()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\illyich_\Desktop\car.txt", System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var car = JsonConvert.DeserializeObject<Car>(line);
                    addToEnd(ref list, car);
                }
            }
        }
        

        void sort(Car[] arr)
        {
            mergesort(ref arr, 0, arr.Length - 1);
        }

        //START_OF_MERGE
        void mergesort(ref Car[] Arr, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
            {
                return;
            }
            int middle = (leftStart + rightEnd) / 2;

            mergesort(ref Arr, leftStart, middle);
            mergesort(ref Arr, middle + 1, rightEnd);
            merge(ref Arr, leftStart, rightEnd);
        }

        void merge(ref Car[] Arr, int leftStart, int rightEnd)
        {
            Car[] temp_Arr = new Car[Arr.Length];

            int leftEnd = (rightEnd + leftStart) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;
            if (down.Checked == true)
                while (left <= leftEnd && right <= rightEnd)
                {
                    if (sortM.Checked == true)
                    {
                        if (Arr[left].Mark.CompareTo(Arr[right].Mark) <= 0)
                        {
                            temp_Arr[index] = Arr[left];
                            left++;
                        }
                        else
                        {
                            temp_Arr[index] = Arr[right];
                            right++;
                        }
                        index++;
                    }else if (sortT.Checked == true)
                    {
                        if (Arr[left].CarType > Arr[right].CarType)
                        {
                            temp_Arr[index] = Arr[left];
                            left++;
                        }
                        else
                        {
                            temp_Arr[index] = Arr[right];
                            right++;
                        }
                        index++;
                    }else if(sortC.Checked == true)
                    {
                        if (Arr[left].FuelPerKm > Arr[right].FuelPerKm)
                        {
                            temp_Arr[index] = Arr[left];
                            left++;
                        }
                        else
                        {
                            temp_Arr[index] = Arr[right];
                            right++;
                        }
                        index++;
                    }
                }
            else
                while (left <= leftEnd && right <= rightEnd)
                {
                    if (sortM.Checked == true)
                    {
                        if (Arr[left].Mark.CompareTo(Arr[right].Mark) >= 0)
                        {
                            temp_Arr[index] = Arr[left];
                            left++;
                        }
                        else
                        {
                            temp_Arr[index] = Arr[right];
                            right++;
                        }
                        index++;
                    }
                    else if (sortT.Checked == true)
                    {
                        if (Arr[left].CarType < Arr[right].CarType)
                        {
                            temp_Arr[index] = Arr[left];
                            left++;
                        }
                        else
                        {
                            temp_Arr[index] = Arr[right];
                            right++;
                        }
                        index++;
                    }
                    else if (sortC.Checked == true)
                    {
                        if (Arr[left].FuelPerKm < Arr[right].FuelPerKm)
                        {
                            temp_Arr[index] = Arr[left];
                            left++;
                        }
                        else
                        {
                            temp_Arr[index] = Arr[right];
                            right++;
                        }
                        index++;
                    }
                }

            Array.Copy(Arr, left, temp_Arr, index, leftEnd - left + 1);
            Array.Copy(Arr, right, temp_Arr, index, rightEnd - right + 1);
            Array.Copy(temp_Arr, leftStart, Arr, leftStart, size);
        }
        //END_OF_MERGE

        //__________________
        //ARRAY WORK

        private static Array ResizeArray(Array arr, int[] newSizes)
        {
            if (newSizes.Length != arr.Rank)
                throw new ArgumentException("arr must have the same number of dimensions " +
                                            "as there are elements in newSizes", "newSizes");

            var temp = Array.CreateInstance(arr.GetType().GetElementType(), newSizes);
            int length = arr.Length <= temp.Length ? arr.Length : temp.Length;
            Array.ConstrainedCopy(arr, 0, temp, 0, length);
            return temp;
        }
        void addToEnd(ref Car[] arr, Car val)
        {
            int len = arr.Length + 1;
            arr = (Car[])ResizeArray(arr, new int[] { len });
            arr[len - 1] = val;
        }

        void addToEnd(ref string[] arr, string val)
        {
            int len = arr.Length + 1;
            arr = (string[])ResizeArray(arr, new int[] { len });
            arr[len - 1] = val;
        }

        void addToEnd(ref bool[] arr, bool val)
        {
            int len = arr.Length + 1;
            arr = (bool[])ResizeArray(arr, new int[] { len });
            arr[len - 1] = val;
        }


        //|||||||||||||||||||||||||||||||||||||

        private void Add_Click(object sender, EventArgs e)
        {
            int Type_temp, FK_temp, FS_temp, Power_temp;
            list = new Car[0];
            if (Int32.TryParse(Type.Text, out Type_temp) && Int32.TryParse(FK.Text, out FK_temp) && 
                Int32.TryParse(FS.Text, out FS_temp) && Int32.TryParse(Power.Text, out Power_temp) && (Type_temp == 0 || Type_temp == 1))
            {
                Car test = new Car(Mark.Text, Type_temp, Power_temp, FK_temp, FS_temp);
                serialize(test);
                addToEnd(ref list, test);
                addLog.Text = "\nSUCCESSFULLY ADDED FOLLOWING:" +
                    $"\nMark :\n\t{Mark.Text}\n" +
                    $"Type :\n\t{Type.Text}\n" +
                    $"Power :\n\t{Power.Text}\n" +
                    $"Fuel Size :\n\t{FS.Text}\n" +
                    $"Fuel/Km :\n\t{FK.Text}\n";
            }
            else
            {
                addLog.Text = "\nWRONG INPUT:" +
                    "\nfollowing must be digits" +
                    $"\nType :\n\t{Type.Text}\n" +
                    $"Power :\n\t{Power.Text}\n" +
                    $"Fuel Size :\n\t{FS.Text}\n" +
                    $"Fuel/Km :\n\t{FK.Text}\n";
            }
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                CarToGrid(list[i]);
            }
        }

        private void sortByMark_Click(object sender, EventArgs e)
        {
            if(sortC.Checked || sortM.Checked || sortT.Checked)
                sort(list);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                CarToGrid(list[i]);
            }
        }



        private void Find_Click(object sender, EventArgs e)
        {
            if(lAndT.Checked == true)
            {
                string[] cars = new string[list.Length];
                for (int i = 0; i < list.Length; i++)
                {
                    cars[i] = list[i].Mark;
                }

                Array.Resize(ref cars, Marks.Count);
                int k = 0;
                foreach (string s in Marks)
                {
                    cars[k] = s;
                    k++;
                }

                Array.Resize(ref hasBoth, Marks.Count);

                int j = 0;
                foreach (string car_mark in Marks)
                {
                    bool light = false, truck = false;

                    for (int i = 0; i < list.Length; i++)
                    {
                        if (car_mark == list[i].Mark)
                        {
                            if (list[i].CarType == 0)
                            {
                                light = true;
                            }
                            else
                            {
                                truck = true;
                            }
                        }
                    }
                    if (light && truck)
                        hasBoth[j] = true;

                    j++;
                }


                findLog.Text = "SEARCHING FOR :\n" +
                    "lightweight and truck:";
                for (int i = 0; i < hasBoth.Length; i++)
                {
                    if (hasBoth[i] == true)
                    {
                        findLog.Text += $"\n\t{cars[i]}";
                    }
                }
            }
            if (size.Checked == true)
            {
                findLog.Text = "SEARCHING FOR SMALLEST AND LARGEST:\n";
                Car min_C, max_C;
                int min, max;
                foreach(string car_mark in Marks)
                {
                    min_C = new Car();
                    max_C = new Car();
                    min = 10000;
                    max = -9;
                    foreach (Car car in list)
                    {
                        if(car.Mark == car_mark)
                        {
                            if (car.FuelTankSize > max)
                            {
                                max = car.FuelTankSize;
                                max_C = car;
                            }
                            if (car.FuelTankSize < min)
                            {
                                min = car.FuelTankSize;
                                min_C = car;
                            }
                        }
                    }
                    findLog.Text += $"\nFuel tank size for {min_C.Mark}:" +
                       $"\n\tminimal : size ({min_C.FuelTankSize})" +
                       $"\n\tmaximal : size ({max_C.FuelTankSize})";
                }

            }
            else if (consume.Checked == true)
            {
                Car min_C = list[0], max_C = list[0];
                int min = 10000, max = -9;
                foreach (Car car in list)
                {
                    if (car.FuelPerKm > max)
                    {
                        max = car.FuelPerKm; 
                        max_C = car;
                    }
                    if (car.FuelPerKm < min)
                    {
                        min = car.FuelPerKm; 
                        min_C = car;
                    }
                }
                findLog.Text = "SEARCHING FOR SMALLEST AND LARGEST:\n" +
                   "Consumtion :" +
                   $"\n\tminimal : {min_C.Mark} - volume ({min_C.FuelPerKm})" +
                   $"\n\tmaximal : {max_C.Mark} - volume ({max_C.FuelPerKm})";
            }
            
        }

        private void hasAllTypes_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach(Car car in list)
            {
                if(car.FuelTankSize/car.FuelPerKm >= Convert.ToInt32(border.Text) && car.CarType == 0)
                {
                    CarToGrid_2(car);
                }
            }
            foreach (Car car in list)
            {
                if (car.FuelTankSize / car.FuelPerKm >= Convert.ToInt32(border.Text) && car.CarType == 1)
                {
                    CarToGrid_2(car);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            list = new Car[0];
            deserialize();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                CarToGrid(list[i]);
            }

            string[] cars = new string[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                cars[i] = list[i].Mark;
            }

            foreach (var s in cars)
                Marks.Add(s);
        }

        private void lAndT_CheckedChanged(object sender, EventArgs e)
        {
            size.Checked = false;
            consume.Checked = false;
        }

        private void consume_CheckedChanged(object sender, EventArgs e)
        {
            lAndT.Checked = false;
        }

        private void size_CheckedChanged(object sender, EventArgs e)
        {
            lAndT.Checked = false;
        }

        //|||||||||||||||||||||||||||||||||||||

    }
}

