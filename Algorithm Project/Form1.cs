using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Algorithm_Project
{
    
    public partial class Form1 : Form
    {
        string str="";
        int[] arr;
        public Form1()
        {
            InitializeComponent();

           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cb_options.Items.Add("Read File");
            cb_options.Items.Add("Write File");
            cb_options.Items.Add("merge sort file");
            cb_options.Items.Add("quik sort file");
            cb_options.Items.Add("heap sort file");
            cb_options.Items.Add("counting sort");
            cb_options.Items.Add("search for number");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line = "";
            
            if (cb_options.SelectedItem == "Read File")
            {
                if (str != "")
                    str = "";
                try
                {
                    StreamReader f = new StreamReader(txt_file.Text);
                    while ((line = f.ReadLine()) != null)
                    {
                        str += line;
                        str += Environment.NewLine;
                    }
                    f.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("enter valid file path");
                }
                
            }
            else if (cb_options.SelectedItem == "Write File")
            {
                StreamWriter f = new StreamWriter("write_test.txt");
                f.Write(str);
                f.Close();
            }
            else if(cb_options.SelectedItem == "search for number")
            {
                int key;
                try
                {
                    if (arr.Length < 1) ;
                    bool b = Int32.TryParse(txt_input.Text, out key);
                    if (b == false)
                    {
                        MessageBox.Show("please enter only numbers");
                    }
                    else
                    {
                        var time = System.Diagnostics.Stopwatch.StartNew();

                        txt_show.Text = binary_search(key, arr).ToString() + "                time binary search function take it is :  ";

                        time.Stop();
                        txt_show.Text += time.Elapsed.TotalMilliseconds.ToString();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("run only in sorted file");
                }
                
            }
            else if (cb_options.SelectedItem == "merge sort file")
            {
                try
                {
                    open();
                    var time = System.Diagnostics.Stopwatch.StartNew();

                    arr = merge_sort(arr);

                    time.Stop();

                    txt_show.Text = "time merg sort function take it is :  " + time.Elapsed.TotalMilliseconds.ToString();
                }
                catch (Exception x)
                {
                    MessageBox.Show("error");
                }
                
            }
            else if (cb_options.SelectedItem == "quik sort file")
            {
                try
                {
                    open();
                    var time = System.Diagnostics.Stopwatch.StartNew();

                    arr = quick_sort(arr, 0, (arr.Length) - 1);

                    time.Stop();

                    txt_show.Text = "time quik sort function take it is :  " + time.Elapsed.TotalMilliseconds.ToString();
                }
                catch(Exception x)
                {
                    MessageBox.Show("error");
                }
                

            }
            else if (cb_options.SelectedItem == "heap sort file")
            {
                try
                {
                    open();
                    var time = System.Diagnostics.Stopwatch.StartNew();
                    
                    arr = heap_sort(arr);

                    time.Stop();

                    txt_show.Text = "time heap sort function take it is :  " + time.Elapsed.TotalMilliseconds.ToString();
                }
                catch(Exception x)
                {
                    MessageBox.Show("error");
                }
            }
            else if (cb_options.SelectedItem == "counting sort")
            {
                try
                {
                    open();
                    var time = System.Diagnostics.Stopwatch.StartNew();

                    arr = count_sort(arr);

                    time.Stop();
                    

                    txt_show.Text = "time count sort function take it is :  " + time.Elapsed.TotalMilliseconds.ToString();
                }
                catch (Exception x)
                {
                    MessageBox.Show("error");
                }

            }
        }
        public void open()
        {
            try
            {
                StreamReader file = new StreamReader(txt_file.Text);
                string s = file.ReadToEnd();
                string[] split = s.Split(' ');
                arr = new int[split.Length];
                int x;
                for (int i = 0; i < split.Length; i++)
                {
                    if (Int32.TryParse(split[i], out x))
                    {
                        arr[i] = x;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("enter valid file path");
            }
        }

        public int binary_search(int key, int[] arr)
        {
            int start = 0, end = arr.Length-1 ;
            int m =(start+end)/ 2;
            while (end >= start)
            {
                if (key == arr[m])
                    return m;
                else if (key > arr[m])
                {
                    start = m+1;
                    m = (start + end) / 2;
                   
                }
                else if (key < arr[m])
                {
                    end = m-1;
                    m = (start + end) / 2;
                }
            }
            return -1;
        }

        public int[] merge_sort(int []arr)
        {
            if (arr.Length  == 1)
                   return arr;
           else if(arr.Length >1)
            {
                int e,a,f;
                int[] arr1 = new int[(arr.Length ) / 2];
                for (e =0;e< (arr.Length ) / 2;e++)
                {
                    arr1[e] = arr[e];
                }
                if((arr.Length) % 2  == 1)
                    a = ((arr.Length ) / 2) + 1;
                else
                    a= (arr.Length ) / 2;
                int[] arr2 = new int[a];

                for (e= (arr.Length ) / 2,f=0; e < (arr.Length); f++,e++)
                {
                    arr2[f] = arr[e];
                }
                arr1 = merge_sort(arr1);
                arr2 = merge_sort(arr2);

                int i =0 ,j = 0,x=0;
                while (i!=arr1.Length && j !=arr2.Length)
                {
                    if (arr1[i] >= arr2[j])
                    {
                        arr[x] = arr2[j];
                        if(j<arr2.Length)
                            j++;
                    }
                      
                    else
                    {
                        arr[x] = arr1[i];
                        if (i<arr1.Length)
                            i++;
                    }
                    x++;
                }
                if (i == arr1.Length)
                {
                    while (j != arr2.Length)
                    {
                        arr[x] = arr2[j];
                        x++;j++;
                    }
                       
                }
                else if(j == arr2.Length)
                {
                    while (i != arr1.Length)
                    {
                        arr[x] = arr1[i];
                        i++;x++;
                    }
                }
            }
            return arr;
        }

        public int[] quick_sort(int []arr,int p ,int r)
        {
            int q = 0;
            if (p < r)
            {
                q = partition(arr, p, r);
                quick_sort(arr, p, q - 1);
                quick_sort(arr, q + 1, r);
            }
            return arr;
        }
        public int partition(int[] arr, int p, int r)
        {
            int pivot = arr[p];
            while (true)
            {
                while (arr[p] < pivot)
                {
                    p++;
                }
                while (arr[r] > pivot)
                {
                    r--;
                }
                if (p < r)
                {
                    swap(arr, p, r);
                }
                else
                {
                    return r;
                }
            }
        }
        
        public int[] heap_sort(int[] arr)
        {
            int heapSize = arr.Length;

            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                max_heap(arr, heapSize, p);

            for (int i = arr.Length - 1; i > 0; i--)
            {
                swap(arr, i, 0);

                heapSize--;
                max_heap(arr, heapSize, 0);
            }
            return arr;
        }

        private static void max_heap(int[] arr, int heapSize, int index)
        {
            int left = index *2;
            int right = (index * 2) + 1;

            int largest = 0;

            if (left < heapSize && arr[left] > arr[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && arr[right] > arr[largest])
                largest = right;

            if (largest != index)
            {
                int temp = arr[index];
                arr[index] = arr[largest];
                arr[largest] = temp;

                max_heap(arr, heapSize, largest);
            }
        }
        public int[] count_sort(int []arr)
        {
            int [] A = new int[arr.Max()+1];
            int[] B = new int[arr.Length];
            for (int i = 0; i < A.Length; i++)
                A[i] = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                    A[arr[i]]++;
            }
            for (int i = 1; i < A.Length; i++)
                A[i] += A[i-1];
            for (int i = arr.Length - 1; i >= 0; i--)
                B[--A[arr[i]]] = arr[i];
            return B;
        }
        public void swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                StreamWriter file = new StreamWriter(txt_output_path.Text);
                for(int i = 0;i<arr.Length;i++)
                {
                    if (i % 20 != 0)
                        str += arr[i] + "  ";
                    else
                        str += Environment.NewLine;
                }
                file.Write(str);
                file.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("enter valid file path");
            }
        }
    }
}
