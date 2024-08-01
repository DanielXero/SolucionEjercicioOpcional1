
/*
 * Módulo 1 - Ejercicios Prácticos (OPCIONAL) (Tipos de Datos y Estructuras de Control)
 */


#region Ejercicio1
/*
 * 1. Dado un valor, devolver un mensaje que diga “El valor es mayor que 100” sólo cuando se cumpla dicha condición.
 */
Console.WriteLine("\t\t***** Ejercicio 1 *****");

string numStr1;
int num1;
string message1 = "El valor es mayor que 100";

do
{
    Console.Write("Ingrese un valor entero: ");
    numStr1 = Console.ReadLine();

} while (!Int32.TryParse(numStr1, out num1));


if (num1 > 100)
{
    Console.WriteLine(message1);
}

#endregion

#region Ejercicio2
/*
 * 2. Pedir un número entero por teclado y calcular si es par o impar.
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 2 *****");
string? numStr2;
int num2;

do
{
    Console.Write("Ingrese un número entero: ");
    numStr2 = Console.ReadLine();
} while (!Int32.TryParse(numStr2, out num2));


Console.WriteLine(num2 + " -> " + ((num2 % 2) == 0 ? "Es Par" : "Es Impar"));

#endregion

#region Ejercicio3
/*
 * 3. Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar. Por ejemplo, 14 cumple con esta condición.
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 3 *****");
string numStr3;
int num3;
string message2 = "";

do
{
    Console.Write("Ingrese un valor entero: ");
    numStr3 = Console.ReadLine();
} while (!Int32.TryParse(numStr3, out num3));


message2 = (num3 / 2.0) % 2 == 1 ? "Es el doble de un impar" : "No es el doble de un impar";

Console.WriteLine(num3 + " -> " + message2);

#endregion

#region Ejercicio4
/*
 * 4. Dada un número del 1 al 10, devolver su “versión” en números romanos.
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 4 *****");
string numStr4;
int num4;
string numRomano = "";
bool isInt = false, band = false;

do
{
    Console.Write("Ingrese un número entero entre 1 y 10: ");
    numStr4 = Console.ReadLine();

    isInt = Int32.TryParse(numStr4, out num4);
} while (!(isInt && (num4 > 0 && num4 <= 10)));



switch (num4)
{
    case 1:
        numRomano = "I";
        break;
    case 2:
        numRomano = "II";
        break;
    case 3:
        numRomano = "III";
        break;
    case 4:
        numRomano = "IV";
        break;
    case 5:
        numRomano = "V";
        break;
    case 6:
        numRomano = "VI";
        break;
    case 7:
        numRomano = "VII";
        break;
    case 8:
        numRomano = "VIII";
        break;
    case 9:
        numRomano = "IX";
        break;
    case 10:
        numRomano = "X";
        break;
    default:
        break;
}



Console.WriteLine($"El número {num4} en número romano es: {numRomano}");
#endregion

#region Ejercicio5
/*
 * 5. Leer el nombre y las edades de dos personas y devolver el nombre del menor. En caso de que tengan la misma edad también debe indicarse. Devolver también la diferencia de edad en caso de corresponder.
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 5 *****");
string? name1, ageStr1, ageStr2;
int age1, age2, diferenciaEdad = 0;
string? name2, message3 = "", message4 = "";

Console.Write("Ingrese un nombre: ");
name1 = Console.ReadLine();
Console.Write($"Ingrese la edad de {name1}: ");
ageStr1 = Console.ReadLine();
Console.Write("Ingrese otro nombre: ");
name2 = Console.ReadLine();
Console.Write($"Ingrese la edad de {name2}: ");
ageStr2 = Console.ReadLine();

Int32.TryParse(ageStr1, out age1);
Int32.TryParse(ageStr2, out age2);


if (age1 < age2)
{
    message3 = name1 + $" es menor ({age1})";
}
else if (age2 < age1)
{
    message3 = name2 + $" es menor ({age2})";
}
else
{
    message3 = name1 + " y " + name2 + $" tienen la misma edad ({age1})";
}


if (name1.Equals(name2, StringComparison.OrdinalIgnoreCase))
{
    diferenciaEdad = Math.Abs(age1 - age2);
    message2 = "Su diferencia de edad es: " + diferenciaEdad;
}

Console.WriteLine(message3);
Console.WriteLine(message2);

#endregion

#region Ejercicio6
/*
 * 6. Escribir un programa que calcule el tipo de un triángulo conociendo la longitud de sus 3 lados. También que calcule su perímetro y su área.
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 6 *****");

int lado1, lado2, lado3, perimetro;
double area = 0.0, semiperimetro = 0.0;
perimetro = 0;
string msg1 = "";

Console.WriteLine("\t\t*****Calcular tipo de Triángulo, Área y Perímetro***\n");
lado1 = GetIntegerDataFromUser("Ingrese lado 1: ");
lado2 = GetIntegerDataFromUser("Ingrese lado 2: ");
lado3 = GetIntegerDataFromUser("Ingrese lado 3: ");


if (lado1 == lado2 && lado2 == lado3)
{
    msg1 = "Triángulo Equilátero";
}
else if ((lado1 != lado2) && (lado2 != lado3) && (lado1 != lado3))
{
    msg1 = "Triángulo Escaleno";
}
else
{
    msg1 = "Triángulo Isóceles";
}

perimetro = lado1 + lado2 + lado3;
semiperimetro = perimetro / 2;
area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));

Console.WriteLine($"\nTipo: {msg1}");
Console.WriteLine($"Área: {area}");
Console.WriteLine($"Perímetro: {perimetro}");

#endregion

#region Ejercicio7
/*
 *  7. Desarrolle un programa que calcule el desglose de una cantidad dada, en billetes y monedas tal que se minimice la cantidad de monedas y billetes.
 *     Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,donde los últimos tres son monedas. (Por ejemplo, para $1,723 se debe
 *     imprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de$20, 1 moneda de $2, 1 moneda de $1). Obviar los signos de billete ($) y
 *     tratar todos los valores como números, para los cálculos.
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 7 *****");
string montoStr, msg2 = "";
int monto, aux;

Console.Write("Ingrese el monto total: ");
montoStr = Console.ReadLine();

Int32.TryParse(montoStr, out monto);

aux = monto % 1000;
monto /= 1000;

if (monto != 0)
{
    msg1 += getMessage(monto, aux, "1000");
}
monto = aux;
aux = aux % 500;
monto /= 500;
if (monto != 0)
{
    msg1 += getMessage(monto, aux, "500"); ;
}
monto = aux;
aux = aux % 200;
monto /= 200;
if (monto != 0)
{
    msg1 += getMessage(monto, aux, "200"); ;
}
monto = aux;
aux = aux % 50;
monto /= 50;
if (monto != 0)
{
    msg1 += getMessage(monto, aux, "50");
}
monto = aux;
aux = aux % 20;
monto /= 20;
if (monto != 0)
{
    msg1 += getMessage(monto, aux, "20");
}
monto = aux;
aux = aux % 10;
monto /= 10;
if (monto != 0)
{
    msg1 += getMessage(monto, aux, "10");
}
monto = aux;
aux = aux % 5;
monto /= 5;
if (monto != 0)
{
    msg1 += monto + " moneda de $5" + (aux == 0 ? "." : ", ");
}
monto = aux;
aux = aux % 2;
monto /= 2;
if (monto != 0)
{
    msg1 += monto + " moneda de $2" + (aux == 0 ? "." : ", ");
}
monto = aux;
aux = aux % 1;
monto /= 1;
if (monto != 0)
{
    msg1 += monto + " moneda de $1" + (aux == 0 ? "." : ", ");
}



Console.WriteLine(msg1);



string getMessage(int monto, int aux, string money)
{
    return monto + $" moneda de ${money}" + (aux == 0 ? "." : ", ");
}
#endregion

#region Ejercicio8
/*
 * 8. Pide un número N, y muestra todos los números del 1 al N.
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 8 *****");

int num5 = GetIntegerDataFromUser("Ingrese un número entero: " );

Console.Write($"Números del (1 al {num5}): ");
for (int i = 1; i <= num5; i++)
{
    Console.Write(i + " ");
}

#endregion



#region Ejercicio9
/*
 * 9. Pedir 15 números y escribir la suma total.
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 9 *****");
double num6, totalSum = 0.0;

Console.WriteLine("\t\tIngresar 15 números\n\n");

for (int i = 1; i <= 15; i++)
{

    num6 = GetIntegerDataFromUser($"Ingrese {i}\u00BA número: ");
    totalSum += num6;
}

Console.WriteLine("La suma total de los números ingresados: " + totalSum);
#endregion

#region Ejercicio10
/*
 * 10.Pide 5 números e indica si alguno es múltiplo de 3.
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 10 *****");

int num7;
string msgMul = "";
Console.WriteLine("\t\tIngresar 5 números\n\n");

for (int i = 1; i <= 5; i++)
{
    num7 = GetIntegerDataFromUser($"Ingrese {i}\u00BA número: ");
    if (num7 % 3 == 0)
    {
        msgMul += num7 + ", ";
    }

}

if (msgMul != "")
{
    Console.WriteLine($"Número/s múltplo de 3 -> {msgMul}\b\b.");
}
else
{
    Console.WriteLine("No se ingresaron números múltiplo de 3");
}
#endregion

#region Ejercicio11
/*
 *  11. Escriba un programa que solicite una contraseña (el texto de la contraseña no es importante) y la vuelva a solicitar hasta que las dos contraseñas coincidan.
*/

Console.WriteLine("\n\n\t\t***** Ejercicio 11 *****");
string password1 = "", password2 = "";

Console.Write("Ingrese una contraseña: ");
password1 = Console.ReadLine();

do
{
    password2 = password1;
    Console.Write("Ingrese otra contraseña: ");
    password1 = Console.ReadLine();
} while (!password1.Equals(password2));

#endregion



#region Ejercicio12
/*
 * 12. Mismo que el anterior pero con un límite de tres peticiones. Luego de las tres peticiones no debe solicitar más la contraseña y terminar el programa.
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 12 *****");
string password3 = "", password4 = "";
int count;

Console.Write("Ingrese una contraseña: ");
password3 = Console.ReadLine();
count = 1;

do
{
    password4 = password3;
    Console.Write("Ingrese otra contraseña: ");
    password3 = Console.ReadLine();
    count++;
} while ((!password3.Equals(password4) && count < 3));
#endregion

#region Ejercicio13
/*
 * 13.Proponer al usuario que adivine un número a base de intentarlo.
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 13 *****");
Random r = new Random();
string opc = "SI";
int num8, numRandom;
bool isAdivino = false;


Console.WriteLine("\t\tAdivinar número entre (1-100)\n\n");

Console.WriteLine("\n\nGenerando número aleatorio!!!\n\n");
numRandom = r.Next(1, 101);

while (opc.Equals("si", StringComparison.OrdinalIgnoreCase))
{

    num8 = GetIntegerDataFromUser("Ingrese número posible: ");
    if (num8 == numRandom)
    {
        isAdivino = true;
        break;
    }

    Console.Write("¿Desesa seguir intentado? (SI/NO): ");
    opc = Console.ReadLine();
}

if (isAdivino)
{
    Console.WriteLine("Felicidades Adivinaste el número aleatorio!!!");
}
else
{
    Console.WriteLine($"Perdiste!!! El número aleatorio era: {numRandom}");
}
#endregion

#region Ejercicio14
/*
 * 14. Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o «menor».
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 14 *****");



Console.WriteLine("\t\tAdivinar número entre (1-100)\n\n");

Console.WriteLine("\n\nGenerando número aleatorio!!!\n\n");
numRandom = r.Next(1, 101);

while (opc.Equals("si", StringComparison.OrdinalIgnoreCase))
{
    num8 = GetIntegerDataFromUser("Ingrese número posible: ");

    if (num8 < numRandom)
    {
        Console.WriteLine("Intenta otra vez. El número a adivinar es mayor.");
    }
    else if (num8 > numRandom)
    {
        Console.WriteLine("Intenta otra vez. El número a adivinar es menor.");

    }
    else
    {
        isAdivino = true;
        break;
    }
    Console.Write("¿Desesa seguir intentado? (SI/NO): ");
    opc = Console.ReadLine();
}

if (isAdivino)
{
    Console.WriteLine("Felicidades Adivinaste el número aleatorio!!!");
}
else
{
    Console.WriteLine($"Perdiste!!! El número aleatorio era: {numRandom}");
}
#endregion

#region Ejercicio15
/*
 *  15. Crea un programa que permita sumar N números. El usuario decide cuándo termina de introducir números al indicar la palabra ‘fin’.
*/

Console.WriteLine("\n\n\t\t***** Ejercicio 15 *****");

string? numStr5;
double suma = 0.0, num9;
bool isFin = false;

Console.WriteLine("\t\t Suma de N números\n\n");


while (!isFin)
{

    Console.Write("Ingrese número (\'fin\' -> para salir): ");
    numStr5 = Console.ReadLine();
    if (Double.TryParse(numStr5, out num9))
    {
        suma += num9;
    }
    else
    {
        isFin = true;
    }

}





Console.WriteLine($"El resultado de la suma de los números ingresados es: {suma}");
#endregion


#region Ejercicio 16
/*
 * 16. Crea un programa que solicite al usuario una cadena de texto y que verifique si es o no un palíndromo
*/


Console.WriteLine("\n\n\t\t***** Ejercicio 16 *****");


int cantidadLetras = 0;

Console.Write("Ingrese palabra: ");
string palabra = Console.ReadLine();
char[] palabraArr = palabra.ToLower().ToCharArray();





for (int i = 0; i < palabraArr.Length; i++)
{
    if (palabraArr[i] == palabraArr[palabraArr.Length - 1 - i])
    {

        cantidadLetras++;

    }

}


Console.WriteLine(cantidadLetras == palabra.Length ? $"{palabra} es palindromo" : $"{palabra} no es palindromo");






#endregion

#region Ejercicio 17
/*
 * 17. Pide al usuario un número x y calcula su factorial
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 17 *****");
string numStr7;
int num10, factorial = 1;
bool isInt2 = false;

do
{
    Console.Write("Ingrese un valor entero positivo (> 0): ");
    numStr7 = Console.ReadLine();

    isInt2 = Int32.TryParse(numStr7, out num10);
} while (!(isInt2 && num10 > 0));

for (int i = num10; i > 0; i--)
{
    factorial *= i;
}

Console.WriteLine($"El factorial de {num10}! es: {factorial}");






#endregion

#region Ejercicio 18
/*
 * 18. Crea un programa que convierta una temperatura en grados Celsius a Fahrenheit o viceversa según la elección del usuario
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 18 *****");
bool isFinalizado = false;
string numStr8;
int numOpc;
bool isInt3 = false;
string respuesta = "";


do
{

    Console.WriteLine("1. Convertir grados Celsius a Fahrenheit");
    Console.WriteLine("2. Convertir grados Fahrenheit a Celsius");
    Console.WriteLine("3. Salir");
    do
    {
        Console.Write("Elige una opcion (1-3): ");
        numStr8 = Console.ReadLine();

        isInt2 = Int32.TryParse(numStr8, out numOpc);
    } while (!(isInt2 && numOpc > 0 && numOpc < 4));

    switch(numOpc)
    {
        case 1:
            Console.Write("Ingrese grado Celsius: ");
            double gradoCelsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (gradoCelsius * 9.0 / 5.0) + 32;
            Console.WriteLine($"Los grados celsius {gradoCelsius} en grado fahrenheit es: {fahrenheit}");
            break;
        case 2:
            Console.Write("Ingrese grado Fahrenheit: ");
            double gradoFahrenheit = Convert.ToDouble(Console.ReadLine());

            double Celsius = (gradoFahrenheit - 32) * 5.0 / 9.0;
            Console.WriteLine($"Los grados fahrenheit {gradoFahrenheit} en grado Celsius es: {Celsius}");
            break;
            
        case 3:
            Console.WriteLine("Haz finalizado con el programa convertidor!!!");
            isFinalizado = true;
            break;
    }


    if (!isFinalizado)
    {
        Console.Clear();
    }

} while (!isFinalizado);

#endregion

#region Ejercicio 19
/*
 * 19. Solicita al usuario un número entero positivo y muestra los primeros 50 números de la secuencia de Fibonacci
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 19 *****");
string numStr9;
int num11, aux1 = 0, aux2 = 1, aux3 = 0;
bool isInt4 = false;

do
{
    Console.Write("Ingrese un valor entero positivo (>= 0): ");
    numStr9 = Console.ReadLine();

    isInt4 = Int32.TryParse(numStr9, out num11);
} while (!(isInt4 && num11 >= 0));


Console.WriteLine($"Los primeros {num11} numeros en la serie fibonacci es: ");

for (int i = 0; i < num11; i++)
{
    Console.Write($"{aux1} ");
    aux3 = aux1 + aux2;
    aux1 = aux2;
    aux2 = aux3;

}






#endregion

#region Ejercicio 20
/*
 * 20. Desarrolla un juego en el que el programa elija una palabra y el usuario tenga que adivinarla letra por letra, con un límite de intentos
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 20 *****");
Console.WriteLine("*****Adivinar Animal 1.0 *****");


string[] animales = {
    "Elefante",
    "Jirafa",
    "Canguro",
    "Tigre",
    "León",
    "Delfín",
    "Pingüino",
    "Cebra",
    "Hipopótamo",
    "Rinoceronte",
    "Oso",
    "Lobo",
    "Zorro",
    "Águila"
};

string animalAleatorio = animales[r.Next(animales.Length - 1)];
int maxIntentos = animalAleatorio.Length;
int cantIntentos = 0;
char letra;
char[] auxChar1 = animalAleatorio.ToLower().ToCharArray();
char[] auxChar2 = new char[animalAleatorio.Length];

Console.Write("Animal aleatorio: (");
for (int i = 0; i < animalAleatorio.Length; i++)
{
    Console.Write("_");
}
Console.WriteLine(")");

while (cantIntentos < maxIntentos)
{
    Console.Write("Ingrese una letra: ");
    letra = Console.ReadLine().ToLower().First();
    for (int i = 0; i < auxChar1.Length; i++)
    {
        if (auxChar1[i] == letra)
        {
            auxChar2[i] = letra;
        }
    }
    cantIntentos++;
    Console.WriteLine($"Intentos {cantIntentos} de {maxIntentos}");

}

Console.WriteLine((auxChar1.SequenceEqual(auxChar2)) ? "Feliciadades Ganaste!!!" : $"Lo siento perdiste!!!\nLa palabra era: {animalAleatorio}");


#endregion

#region Ejercicio21
/*
 * 21 (EXTRA). Adaptar el programa anterior para que a medida que el usuario falle, la aplicación autocomplete  la palabra letra a letra a modo de pistas para el usuario. 
 * El numero de intentos estará dado por la cantidad de letras restantes que el usuario tenga que adivinar. Ejemplo: La palabra ADIVINAR tendrá 8 intentos. Si la forma de 
 * la palabra es AD_V_NA_ son 3 intentos
*/
Console.WriteLine("\n\n\t\t***** Ejercicio 21 *****");
Console.WriteLine("*****Adivinar Animal 2.0 *****");


string[] animales2 = {
    "Elefante",
    "Jirafa",
    "Canguro",
    "Tigre",
    "León",
    "Delfín",
    "Pingüino",
    "Cebra",
    "Hipopótamo",
    "Rinoceronte",
    "Oso",
    "Lobo",
    "Zorro",
    "Águila",
    "Paloma"

};

 animalAleatorio = animales2[r.Next(animales.Length - 1)];
 maxIntentos = animalAleatorio.Length;
 int cantIntentos2 = 0, cantIntentos3 = 0;

auxChar1 = animalAleatorio.ToLower().ToCharArray();
 auxChar2 = new char[animalAleatorio.Length];
char[] auxChar3 = new char[animalAleatorio.Length];
bool isAdivinoLetra;

Console.Write("Animal aleatorio: (");
for (int i = 0; i < animalAleatorio.Length; i++)
{
    Console.Write("_");
}
Console.WriteLine(")");

while (cantIntentos != maxIntentos)
{
    Console.Write("Ingrese una letra: ");
    letra = Console.ReadLine().ToLower().First();
    isAdivinoLetra = false;
    for (int i = 0; i < auxChar1.Length; i++)
    {
        if (auxChar1[i] == letra)
        {
            auxChar2[i] = letra;
            isAdivinoLetra = true;
        }
    }

    if (!isAdivinoLetra)
    {
        for (int i = 0; i < maxIntentos; i++)
        {
            if (auxChar1[cantIntentos] == auxChar1[i] && auxChar2[i] == '\0')
            {
                auxChar2[i] = auxChar1[i];

            }
        }
    }
    Console.Write("Animal aleatorio: (");
    for (int i = 0; i < maxIntentos; i++)
    {
        if (auxChar2[i] != '\0')
        {
            Console.Write(auxChar2[i]);
            cantIntentos3++;
        }
        else
        {

            Console.Write("_");
        }
    }
    cantIntentos = cantIntentos3;
    Console.WriteLine(")");
    cantIntentos++;
    Console.WriteLine($"Intentos {maxIntentos - cantIntentos2}");

}

Console.WriteLine((auxChar1.SequenceEqual(auxChar2)) ? "\nFeliciadades Ganaste!!!" : $"\nLo siento perdiste!!!\nLa palabra era: {animalAleatorio}");


/*
 *  Disculpen este ejercicio me falto corregir que se atualize la cantidad de intentos que queda.
 * 
 * */

#endregion

#region FuncionValidaDatoEnteroUsuario
int GetIntegerDataFromUser(string message)
{
    string userData;
    int data = 0;
    bool isDataValid = false;


    while (!isDataValid)
    {
        Console.Write(message);
        userData = Console.ReadLine();

        if (!Int32.TryParse(userData, out data))
        {
            Console.WriteLine("El dato que ingresaste no es valido. Vuelve a intentarlo");
        }
        else
        {
            isDataValid = true;
        }


    }

    return data;
}


#endregion


