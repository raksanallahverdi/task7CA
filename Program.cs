// int[,] array =
// {
//     {1,0,300 },
//     {50,40,-20 },
//     {70,-90,3 }
// };

// task1
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//         Console.Write(array[i,y]+" ");
//     }
//     Console.WriteLine();
// }

// task2
// int sum=0;
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//       sum+=array[i,y];
//     }
// }
// System.Console.WriteLine(sum);

// task3
// int sum=0;
// for (int i=0;i<array.GetLength(0);i++)
// {
//       sum+=array[i,0];
// }
// System.Console.WriteLine(sum);

// task4 neqativ 
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//         if (array[i,y]<0){

//             Console.Write(array[i,y]+" ");
//         }

//     }
// }

// task5 min ve max
// int min=array[0,0];
// int max=array[0,0];
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//         if(array[i,y]>max){
//             max=array[i,y];
//         }
//         if(array[i,y]<min){
//             min=array[i,y];
//         }
//     }
// }
// Console.WriteLine(min);
// Console.WriteLine(max);



// int[,] array =
// {
//     {1,0,300 },
//     {50,40,-20 },
//     {70,-90,-3 }
// };


// task6 
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {

//         if (array[i,y]==0){
//             continue;
//         }
//         else if(array[i,y]>0){
//             if(array[i,y]%2==0){
//                 array[i,y]=2;
//             }
//             else {
//                 array[i,y]=1;
//             }
//         }
//         else{
//             if(array[i,y]%2==0){
//                 array[i,y]=-2;
//             }
//             else {
//                 array[i,y]=-1;
//             }
//         }
//     }
// }
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//         Console.Write(array[i,y]+" ");
//     }
//     Console.WriteLine();
// }


// int[,] array =
// {
//     {22,99,500,13},
//     {1,0,300,40 },
//     {50,40,-20,50 },
//     {70,-90,3,9 }
// };

// task7
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//       array[1,y]=0;
//     }
// }
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//         Console.Write(array[i,y]+" ");
//     }
//     Console.WriteLine();
// }

// task8
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//       array[2,y]=0;
//     }
// }
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//         Console.Write(array[i,y]+" ");
//     }
//     Console.WriteLine();
// }



// int[,] array =
// {
//     {22,99,500,13}, 
//     {1, 0,300,40 },
//     {50,40,-20,50 },
//     {70,-90,3, 9 }
// };

// task9 sol diaqonal cemi
// int sum=0;
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//       if(i==y){
//         sum+=array[i,y];
//       }
//     }
// }
// Console.WriteLine(sum);


// int[,] array =
// {
//     {22,99,500,13}, 
//     {1, 0,300,40 },
//     {50,40,-20,50 },
//     {70,-90,3, 9 }
// };

// task10 sag diaqonal
// int sum=0;
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//         if (i+y==3){
//             sum+=array[i,y];
//         }
      
//     }
// }
// Console.WriteLine(sum);

// int[,] array =
// {
//     {890,34,5,280,11},
//     {22,99,500,13,40},  
//     {1, 30,300,40,66 },
//     {50,40,-20,50,7 },
//     {70,-90,3, 9,15 }
// };
// task11
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//         if (i>y){
//             array[i,y]=0;
//         }
      
//     }
// }
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//         Console.Write(array[i,y]+" ");
//     }
//     Console.WriteLine();
// }

// task12
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//         if (i<y){
//             array[i,y]=0;
//         }
      
//     }
// }
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//         Console.Write(array[i,y]+" ");
//     }
//     Console.WriteLine();
// }



// int[,] array1 =
// {
//     {890,34,5}, 
//     {1, 30,300},
//     {50,40,-20}
// };
// int[,] array2 =
// {
//     {890,34,5}, 
//     {1, 30,300},
//     {50,40,-20}
// };


// task13 arraylari toplamaq
// int[,] array3=new int[3,3];
// for (int i=0;i<array3.GetLength(0);i++)
// {
//     for (int y=0;y<array3.GetLength(1);y++)
//     {
//         array3[i,y]=array1[i,y]+array2[i,y];
//     }
   
// }
// for (int i=0;i<array3.GetLength(0);i++)
// {
//     for (int y=0;y<array3.GetLength(1);y++)
//     {
//         Console.Write(array3[i,y]+" ");
//     }
//     Console.WriteLine();
// }

// int[,] array =
// {
//     {890,34,5}, 
//     {1, 30,300},
//     {50,40,-20}
// };
// task14 rowlarin
// int sum1=0;
// int sum2=0;
// int sum3=0;
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//       sum1=array[0,y];
//       sum2=array[1,y];
//       sum3=array[2,y];
//     }
// }
// Console.WriteLine(sum1);
// Console.WriteLine(sum2);
// Console.WriteLine(sum3);

// // task15 columnlarin cemi
// int sum1=0;
// int sum2=0;
// int sum3=0;
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//       sum1=array[i,0];
//       sum2=array[i,1];
//       sum3=array[i,2];
//     }
// }
// Console.WriteLine(sum1);
// Console.WriteLine(sum2);
// Console.WriteLine(sum3);

// int[,] array1 =
// {
//     {890,34,5}, 
//     {1, 30,300},
//     {50,40,-20}
// };
// int[,] array2 =
// {
//     {890,34,5}, 
//     {1, 30,300},
//     {50,40,-20}
// };

// task17 arraylarin hasili
// int[,] array3=new int[3,3];
// for (int i=0;i<array3.GetLength(0);i++)
// {
//     for (int y=0;y<array3.GetLength(1);y++)
//     {
//         array3[i,y]=array1[i,y]*array2[i,y];
//     }
//     }

// for (int i=0;i<array3.GetLength(0);i++)
// {
//     for (int y=0;y<array3.GetLength(1);y++)
//     {
//         Console.Write(array3[i,y]+" ");
//     }
//     Console.WriteLine();
// }



// int[,] array =
// {
//     {13,34,890}, 
//     {1, 9,300},
//     {50,40,7}
// };

// // task18 sade ededler
// bool isComplex=false;
// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int y=0;y<array.GetLength(1);y++)
//     {
//          isComplex=false;
//         int kok=Convert.ToInt32(Math.Sqrt(array[i,y]));
//         for (int k=2;k<=kok;k++){
//             if (array[i,y]%k==0){
//                 isComplex=true;
//             }
//         }
//          if (!isComplex && array[i,y]!=1 ){
//            Console.WriteLine(array[i,y]);
//         }
        
//     }
// }

































