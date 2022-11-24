// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// VARIÁVEIS

char meuChar = 'a';
string minhaString = "palavra";

int inteiro = 22;
double meuDouble = 21.3;
decimal meuDecimal = 21.3m;
float meuFloat = 21.3f;
// observação: C# não aceita repetição de números entre "decimal" e "float" sem a declaração dos tipos após
// o ponto flutuante.

bool meuBoolean = true;

/* também é 
possível 
comentar 
assim */

// FOR

int a = 10;
int b = 10;

for (int i = 1; i <= 5; i++) {
    Console.WriteLine("Volta: " + i);

    Console.WriteLine(a);
    Console.WriteLine(b);

    a++;
    b--;

    Console.WriteLine(a);
    Console.WriteLine(b);
}