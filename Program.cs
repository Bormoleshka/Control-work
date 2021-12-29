//Task1.
            Random rand = new Random();
           int count=0;
           
            int [] arr = new int[15];//создали массив
             
            
            for(int i=0; i<arr.Length;i++)
            {
                arr[i] = rand.Next(1, 50);
                Console.Write(arr[i] + " ");
                    if(arr[i]%2==0)
                        count++;
            }
            Console.WriteLine();//выводим получившийся массив
             if (count == 0)
                Console.WriteLine("Четные числа отсутствуют");
            else
            {
                
                int j = 0;
                int[] arr1 = new int[count];
                Console.WriteLine("массив четных чисел:");
                for(int i=0; i<arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        arr1[j]=arr[i];
                        Console.Write(arr1[j]+" ");
                        j++;
                    }
                }
            }
            Console.ReadKey();//выводим требуемый массив из четных чисел
 
 
           
            
            
           