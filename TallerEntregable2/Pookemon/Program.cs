using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Microsoft.VisualBasic;

namespace Pookemon.OOP{

    public class Program{
        static void Main(string[] args){
            int Opc=0;
            bool Flag = false;
            do{
                Console.WriteLine("Porfavor, Digite lo que desea hacer");
                Console.WriteLine("1. Crear Pookemon");
                Console.WriteLine("2. Ver stats de Pookemon");
                Console.WriteLine("3. Pelear");
                Console.WriteLine("4. Salir");
                switch(Opc){
                    case 1:
                    Console.WriteLine("Porfavor digita el nombre del pookemon a crear");
                    string Nomb = Console.ReadLine();
                    Console.WriteLine("Ahora su tipo");
                    string Type = Console.ReadLine();
                    Pookemon = Nomb = new Pookemon(Nomb, Type);
                    Console.WriteLine("Pookemon registrado exitosamente!");
                    break;
                    case 2:
                    Console.WriteLine("Porfavor digite el nombre del pookemon (Campo case sensitive)");
                    string Nmb = Console.ReadLine();
                    Nmb.pDatos();
                    Nmb.get
                    break;
                    case 3:
                    Console.WriteLine("Porfavor digite el nombre del primer pookemon (Campo case sensitive)");
                    string Nb1 = Console.ReadLine();
                    Console.WriteLine("Ahora el segundo");
                    string Nb2 = Console.ReadLine();
                    Console.WriteLine("Los pookemon " + Nb1 + " y " Nb2 + " pelearan");
                    int hp1=150;
                    int hp2=150;
                    for (int i = 0; i < 3; i++){
                        Console.WriteLine("Es turno de " + Nb1 + " ¿Que desea que haga?");
                        Console.WriteLine("1.Ataque");
                        Console.WriteLine("2.Defensa");
                        Flag1=false;
                        int Val1=0;
                        int Val2=0;
                        int Tp1=0;
                        int Tp2=0;
                        do{
                        switch(Opc2){
                            case 1:
                            Tp1=1;
                            AtkI=Random().Next(1-3);
                            AtkIV=Random().Next(1-3);
                            AtkV=0;
                            if(AtkI==1){
                                AtkV=Nb1.Atk1();
                            }else if (AtkI==2){
                                AtkV=Nb1.Atk2();
                            }else if (AtkI==3){
                                AtkV=Nb1.Atk3();
                            }
                            if(AtkIV==1){
                                AtkV=AtkV*0;
                            }else if (AtkIV==2){
                                AtkV=AtkV*1;
                            }else if (AtkIV==3){
                                AtkV=AtkV*1.5;
                            }
                            Val1=AtkV;
                            Flag1=true;
                            break;
                            case 2:
                            Tp1=2;
                            DefI=Random().Next(1-2);
                            DefIV=Random().Next(1-3);
                            AtkV=0;
                            if(DefI==1){
                                AtkV=Nb1.ADef1();
                            }else if (DefI==2){
                                AtkV=Nb1.Def2();
                            }
                            if(DefIV==1){
                                AtkV=AtkV*0.5;
                            }else if (DefIV==2){
                                AtkV=AtkV*1;
                            }
                            Flag1=true;
                            Val1=AtkV;
                            break;
                            default:
                            Console.WriteLine("Opcion fuera de rango");
                            break;
                        }
                        }while(Flag2==false);

                        Console.WriteLine("Es turno de " + Nb2 + " ¿Que desea que haga?");
                        Console.WriteLine("1.Ataque");
                        Console.WriteLine("2.Defensa");
                        Flag2=false;
                        do{
                        switch(Opc2){
                            case 1:
                            Tp2=1
                            AtkI=Random().Next(1-3);
                            AtkIV=Random().Next(1-3);
                            AtkV=0;
                            if(AtkI==1){
                                AtkV=Nb1.Atk1();
                            }else if (AtkI==2){
                                AtkV=Nb1.Atk2();
                            }else if (AtkI==3){
                                AtkV=Nb1.Atk3();
                            }
                            if(AtkIV==1){
                                AtkV=AtkV*0;
                            }else if (AtkIV==2){
                                AtkV=AtkV*1;
                            }else if (AtkIV==3){
                                AtkV=AtkV*1.5;
                            }
                            Flag2=true;
                            Val2=AtkV;
                            break;
                            case 2:
                            Tp2=2;
                            DefI=Random().Next(1-2);
                            DefIV=Random().Next(1-3);
                            AtkV=0;
                            if(DefI==1){
                                AtkV=Nb1.ADef1();
                            }else if (DefI==2){
                                AtkV=Nb1.Def2();
                            }
                            if(DefIV==1){
                                AtkV=AtkV*0.5;
                            }else if (DefIV==2){
                                AtkV=AtkV*1;
                            }
                            Flag2=true;
                            Val2=AtkV;
                            break;
                            default:
                            Console.WriteLine("Opcion fuera de rango");
                            break;
                        } 
                    }while(Flag2==false);

                    if(Tp1==1 && Tp2==1){
                        hp2-=Val1;
                        hp1-=Val2;
                        Console.WriteLine(Nb1 + " recibe " + Val2 + " de daño y " + Nb2 + " recibe " + Val1 + " de daño!");
                    }else if(Tp1==2 && Tp2==2){
                        Console.WriteLine("Ambos pookemon bloquean, ninguno recibe daño.");
                    }else if(Tp1==1 && Tp2==2){
                        if(Val1 > Val2){
                            Console.WriteLine(Nb1 + " impacta a" + Nb2 + " por " + (Val1-Val2) + " de daño!");
                            hb2-=(Val1-Val2);
                        }else if (Val1 < Val2){
                            Console.WriteLine(Nb2 + " bloquea y contraataca a " + Nb1 + " por " + (Val2-Val1) + " de daño");
                            hp1-=(Val2-Val1);
                        }else if (Val1==Val2){
                            Console.WriteLine("El daño es igual a la defensa, por lo que es mitigado");
                        }
                    }else if(Tp1==2 && Tp2==1){
                        if(Val1 < Val2){
                            Console.WriteLine(Nb2 + " impacta a" + Nb1 + " por " + (Val2-Val1) + " de daño!");
                            hp1-=(Val2-Val1);
                        }else if (Val1 > Val2){
                            Console.WriteLine(Nb1 + " bloquea y contraataca a " + Nb2 + " por " + (Val1-Val2) + " de daño");
                            hp2-=(Val1-Val2);
                        }else if (Val1==Val2){
                            Console.WriteLine("El daño es igual a la defensa, por lo que es mitigado");
                        }
                    }
                    if(hp1==hp2){
                        Console.WriteLine("Ambos pookemones quedaron con la misma cantidad de vida, es un empate!");
                        Console.WriteLine(Nb1 + ": " + hp1);
                        Console.WriteLine(Nb2 + ": " + hp2);
                    }else if (hp1>hp2){
                        Console.WriteLine("El Pookemon " + Nb1 + "Es el ganador!");
                        Console.WriteLine(Nb1 + ": " + hp1);
                        Console.WriteLine(Nb2 + ": " + hp2);
                    }else if (hp2>hp1){
                        Console.WriteLine("El Pookemon " + Nb2 + "Es el ganador!");
                        Console.WriteLine(Nb1 + ": " + hp1);
                        Console.WriteLine(Nb2 + ": " + hp2);
                    }
                    break;
                    case 4:
                    Flag=true;
                    break;
                    default:
                    Console.WriteLine("Valor invalido");
                    break;
                }
            }while(Flag==false);
        }

    }
}
}