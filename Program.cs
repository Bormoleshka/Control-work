
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
           
            
            
           