using System;
using System.Collections;

namespace MaquinaTuring
{
    class Program
    {
        // caracteers
        // 0 1 
        // _ ----> vacio 
        public static void Vacios(char[] x,char[] y,char[] cont,char[] resl){
            
            for(int i = 0 ; i < 10; i++){
                x[i] = '_'; 
                y[i] = '_'; 
                cont[i] = '_'; 
                resl[i] = '_'; 
            }
        }

        public static void DecoInstruccion(char[] x,char[] y,char[] cont,char[] resul, int indx, int indy, int indcont, int indresl){
            // Console.WriteLine(x[indx]);
            bool termino = false;
            int estado = 0;

            while(!termino){
            // for(int i = 0; i< 40 ; i++){

                Console.WriteLine("estado: " +  estado );
                Console.WriteLine("[{0}]", string.Join(", ", x));
                Console.WriteLine("[{0}]", string.Join(", ", cont));
                Console.WriteLine("[{0}]", string.Join(", ", resul));
                //intrucciones
                if(estado == 0){
                    //1
                    if(x[indx] == '0' && y[indy] == '0' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '0';
                        y[indy] = '0';
                        indx++;
                        indy++;
                        estado = 0;
                        //break;
                    }else if(x[indx] == '1' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '1';
                        y[indy] = '1';
                        indx++;
                        indy++;
                        estado = 0;
                        //break;
                    }else if(x[indx] == '1' && y[indy] == '0' && cont[indcont] == '_' && resul[indresl] == '_'){//2
                        x[indx] = '1';
                        y[indy] = '0';
                        indx++;
                        indy++;
                        estado = 1;
                        //break;
                    }else if(x[indx] == '0' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){//9
                        x[indx] = '0';
                        y[indy] = '1';
                        cont[indcont] = '_';
                        resul[indresl] = '1';
                        indx++;
                        indy++;
                        indcont--;
                        estado = 2;
                        termino = true;
                        break;
                    }else if(x[indx] == '_' && y[indy] == '_' && cont[indcont] == '_' && resul[indresl] == '_'){//6
                        x[indx] = '_';
                        y[indy] = '_';
                        indx++;
                        indy++;
                        estado = 3;
                        Console.WriteLine("indx:"+indx);
                        Console.WriteLine("indy:"+indy);
                        Console.WriteLine("indy:"+indcont);
                        // break;
                    }
                }else if(estado == 3){
                    //7
                    if(x[indx] == '_' && y[indy] == '_' && cont[indcont] == '1' && resul[indresl] == '_'){
                        x[indx] = '_';
                        y[indy] = '_';
                        cont[indcont] = '1';
                        resul[indresl] = '1';
                        termino = true;
                        estado = 5;
                        break;
                    }else if(x[indx] == '_' && y[indy] == '_' && cont[indcont] == '_' && resul[indresl] == '_'){//8
                        x[indx] = '_';
                        y[indy] = '_';
                        cont[indcont] = '1';
                        resul[indresl] = '1';
                        indx++;
                        indy++;
                        termino = true;
                        estado = 4;
                        break;
                    }
                }else if(estado == 1){
                   
                    //3
                    if(x[indx] == '0' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '0';
                        y[indy] = '1';
                        indx++;
                        indy++;
                        estado = 1;
                    }else if(x[indx] == '0' && y[indy] == '0' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '0';
                        y[indy] = '0';
                        indx++;
                        indy++;
                        estado = 1;
                    }else if(x[indx] == '1' && y[indy] == '0' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '1';
                        y[indy] = '0';
                        indx++;
                        indy++;
                        estado = 1;
                    }else if(x[indx] == '1' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '1';
                        y[indy] = '1';
                        indx++;
                        indy++;
                        estado = 1;
                    }else if(x[indx] == '_' && y[indy] == '_' && cont[indcont] == '_' && resul[indresl] == '_'){//4
                        x[indx] = '_';
                        y[indy] = '_';
                        cont[indcont] = '1';
                        indx--;
                        indy--;
                        indcont++;
                        estado = 6;
                        // break;
                    }
                    
                    
                }else if(estado == 6){
                    //5
                    if(x[indx] == '_' && y[indy] == '_' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '_';
                        y[indy] = '_';
                        indx++;
                        indy++;
                        estado = 0;
                        // break;
                    }else if(x[indx] == '1' && y[indy] == '0' && cont[indcont] == '_' && resul[indresl] == '_'){//10
                        x[indx] = '1';
                        y[indy] = '0';
                        estado = 8;
                        // break;
                    }else if(x[indx] == '0' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){//14
                        x[indx] = '1';
                        y[indy] = '1';
                        indx--;
                        estado = 9;
                        // break;
                    }else if(x[indx] == '1' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){  //12
                        x[indx] = '0';
                        y[indy] = '1';
                        estado = 7;
                        // break;
                    }else if(x[indx] == '0' && y[indy] == '0' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '0';
                        y[indy] = '0';
                        estado = 7;
                        // break;
                    }
                }else if(estado == 8){
                    //11
                    if(x[indx] == '1' && y[indy] == '0' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '1';
                        y[indy] = '0';
                        indx--;
                        indy--;
                        estado = 6;
                        // break;
                    }
                }else if(estado == 9){
                    //15
                    if(x[indx] == '0' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '1';
                        y[indy] = '1';
                        indx--;
                        estado = 10;
                        // break;
                    }else if(x[indx] == '1' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){//16
                        x[indx] = '0';
                        y[indy] = '1';
                        indx++;
                        estado = 12;
                        // break;
                    }
                }else if(estado == 10){
                    //17
                    if(x[indx] == '1' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '0';
                        y[indy] = '1';
                        indx++;
                        estado = 11;
                        // break;
                    }
                }else if(estado == 11){
                    //18
                    if(x[indx] == '1' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '1';
                        y[indy] = '1';
                        indx++;
                        estado = 12;
                        // break;
                    }
                }else if(estado == 12){
                    //19
                    if(x[indx] == '1' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '1';
                        y[indy] = '1';
                        indx--;
                        indy--;
                    }
                    estado = 6;
                    // break;
                }else if(estado == 7){
                    //13
                    if(x[indx] == '0' && y[indy] == '0' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '0';
                        y[indy] = '0';
                        indx--;
                        indy--;
                    }else if(x[indx] == '0' && y[indy] == '1' && cont[indcont] == '_' && resul[indresl] == '_'){
                        x[indx] = '0';
                        y[indy] = '1';
                        indx--;
                        indy--;
                    }
                    estado = 6;
                    // break;
                } 
            }

            Console.WriteLine("estado: " +  estado );
            Console.WriteLine("[{0}]", string.Join(", ", x));
            Console.WriteLine("[{0}]", string.Join(", ", cont));
            Console.WriteLine("[{0}]", string.Join(", ", resul));
        }

        static void Main(string[] args)
        {
            //Creacion de cintas
            char[] x = new char[10];
            char[] y = new char[10];
            char[] cont = new char[10];
            char[] resl = new char[10];
            Vacios(x,y,cont,resl);
            
            Console.WriteLine("Ingrese el primer Binario");
            for(int i = 2 ; i < 5; i++){
                x[i] = Console.ReadLine().ToCharArray()[0];
            }

            Console.WriteLine("Ingrese el segundo Binario");
            for(int i = 2 ; i < 5; i++){
                y[i] = Console.ReadLine().ToCharArray()[0];
            }

            Console.WriteLine("__________________________");

            int indx = 2;
            int indy = 2;
            int indcont = 2;
            int indresl = 2;

            DecoInstruccion(x,y,cont,resl,indx,indy,indcont,indresl);

            Console.WriteLine("El resultado es: ");
            Console.WriteLine("[{0}]", string.Join(", ", cont));

            int resultadoEntero = 0;
            for(int i = 0; i < cont.Length; i++){
                if(cont[i] == '1'){
                    resultadoEntero++;
                }
            }

            Console.WriteLine("Entero:" + resultadoEntero);
            Console.WriteLine("Binario:" + Convert.ToString(resultadoEntero,2));
        }
    }
}
