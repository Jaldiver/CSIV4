bool Ciclo = false;

while (Ciclo==false){
    Console.WriteLine("Bienvenido al taller n°1 de Construccion de Software IV");
    Console.WriteLine("Porfavor digite el numero relacionado a la opcion relacionada al punto que quiera probar");
    Console.WriteLine("1. Calculadora de fracciones");
    Console.WriteLine("2. Número especial");
    Console.WriteLine("3. Dias y semanas");
    Console.WriteLine("4. Sistema de inicio de sesión");
    Console.WriteLine("5. Terminar");

    int Opt = int.Parse(Console.ReadLine());

    switch(Opt)
    {
        case 1:
            Console.WriteLine("Porfavor digite el diviendo del primer fraccionrio");
            float Div1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora el divisor");
            float Div2 = float.Parse(Console.ReadLine());
            if(Div2==0){
            do{
                Console.WriteLine("El divisor no puede ser 0.");
                Div2 = float.Parse(Console.ReadLine());
            }while(Div2==0);
            }
            float Val1 = Div1/Div2;

            Console.WriteLine("Ahora el diviendo del segundo fraccionario");
            Div1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora el divisor");
            Div2 = float.Parse(Console.ReadLine());
            if(Div2==0){
            do{
                Console.WriteLine("El divisor no puede ser 0.");
                Div2 = float.Parse(Console.ReadLine());
            }while(Div2==0);
            }
            float Val2 = Div1/Div2;
            Console.WriteLine("Ahora indique el tipo de operacion que quiere usar (+, -, /, *)");
            bool Chk=false;
            do{
            string Opr = Console.ReadLine();
            switch(Opr){
                case "+":
                    Console.WriteLine("El resultado de la suma es: " + (Val1+Val2));
                    Chk=true;
                break;
                case "-":
                    Console.WriteLine("El resultado de la resta es: " + (Val1-Val2));
                    Chk=true;
                break;
                case "*":
                    Console.WriteLine("El resultado de la multiplicación es: " + (Val1*Val2));
                    Chk=true;
                break;
                case "/":
                    Console.WriteLine("El resultado de la división es: " + (Val1/Val2));
                    Chk=true;
                break;
                default:
                Console.WriteLine("Opcion fuera de rango.");
                break;
                }
            }while(Chk==false);
        break;
        case 2:
            Console.WriteLine("Porfavor digite el numero que desea se pruebe si es un numero especial o no");
            Console.WriteLine("Las condiciones para un numero especial son:");
            Console.WriteLine("- Es divisible por 5");
            Console.WriteLine("- No es divisible entre 3 o 2");
            int ValEsp = int.Parse(Console.ReadLine());
            if ((ValEsp % 5)==0){
                if((ValEsp % 3)== 0 || (ValEsp % 2)== 0 ){
                    Console.WriteLine("El numero " + ValEsp + " no cumple con los requisitos para ser un numero especial");
                }else{
                    Console.WriteLine("El numero " + ValEsp + " cumple las condiciones para ser un numero especial");
                }
            }else{
                Console.WriteLine("El numero " + ValEsp + " no cumple con los requisitos para ser un numero especial");
            }
        break;
        case 3:
            Console.WriteLine("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            int añoactual = DateTime.Now.Year;
            int añonacimiento = añoactual - edad;
            int diastranscurridos = 0;
            for(int año = añonacimiento; año <= añoactual; año++){
                if(DateTime.IsLeapYear(año)){
                    diastranscurridos += 366;
                }
                else{
                    diastranscurridos +=365;
                }
            }
            int semanastranscurridas = diastranscurridos / 7;
            Console.WriteLine("Han transcurrido aproximadamente {0} dias y {1} semanas desde tu nacimiento hasta hoy. ", diastranscurridos, semanastranscurridas );

            Console.WriteLine("Introduce tu fecha de nacimiento (formato: dd/mm/aaaa):");
            DateTime fechaNacimiento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            DateTime fechaActual = DateTime.Today;

            edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad)){
                edad--;
            }

            int diasTranscurridos = (fechaActual - fechaNacimiento).Days;

            int semanasTranscurridas = diasTranscurridos / 7;

            Console.WriteLine("Tienes {0} años de edad.", edad);
            Console.WriteLine("Han transcurrido aproximadamente {0} días y {1} semanas desde tu nacimiento hasta hoy.", diasTranscurridos, semanasTranscurridas);
        break;
        case 4:
            string usuario = "admin";
            string contraseña = "12345";
            int intento = 3;

            while (intento>0){
                Console.WriteLine("Ingrese su usuario");
                string usuario2 = Console.ReadLine();

                Console.WriteLine("Ingrese su contraseña");
                string contraseña2 = Console.ReadLine();

                if (usuario2==usuario && contraseña2==contraseña){
                    Console.WriteLine("Acceso Concedido");
                    break;
                }else{
                    intento--;
                    Console.WriteLine("Usuario o contraseña Incorrectos. Intentos restantes: " + intento);
                }
            }
            if (intento == 0){
                Console.WriteLine("Acceso Denegado. El programa se cerrará");
            }
        break;
        case 5:
        Ciclo = true;
        break;
        default:
            Console.WriteLine("Opcion fuera de rango");
        break;
    }
}
