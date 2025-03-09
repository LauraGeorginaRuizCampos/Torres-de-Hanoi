#Torres de Hanoi

# Torres de Hanoi

Este proyecto implementa el famoso problema de las **Torres de Hanoi** utilizando el lenguaje de programación **C#** y estructuras de datos de tipo pila.

## Descripción del Problema
El problema de las Torres de Hanoi consiste en mover una pila de discos desde una torre de origen hasta una torre de destino, siguiendo estas reglas:
1. Solo se puede mover un disco a la vez.
2. Un disco más grande no puede colocarse sobre uno más pequeño.
3. Solo se puede mover el disco que está en la parte superior de una torre.

El objetivo es trasladar toda la pila de discos desde la **torre de origen** hasta la **torre de destino**, utilizando una **torre auxiliar** en el proceso y cumpliendo las reglas anteriores.

## Estructura del Código
El código está dividido en los siguientes archivos:

### 1. **Nodos (Nodos.cs)**
Define la estructura de un **nodo**, que representa un disco en la pila. Cada nodo contiene:
- Un valor entero que representa el tamaño del disco.
- Una referencia al siguiente nodo en la pila, lo que permite enlazar varios nodos y formar la estructura de pila.

Ejemplo de definición de un nodo:
```csharp
class Nodo {
    public int Valor;
    public Nodo Siguiente;
    
    public Nodo(int valor) {
        this.Valor = valor;
        this.Siguiente = null;
    }
}
```

### 2. **Pilas (Pilas.cs)**
Implementa la estructura de **pila** para simular las varillas. Se utiliza una lista enlazada para representar la pila, con un nodo en la cima que representa el disco superior.

Métodos principales:
- `Push(int valor)`: Agrega un nuevo disco a la pila.
- `Pop()`: Retira el disco superior de la pila y lo devuelve.
- `Peek()`: Obtiene el valor del disco en la cima sin retirarlo.
- `IsEmpty()`: Verifica si la pila está vacía.

Ejemplo de implementación:
```csharp
class Pila {
    private Nodo cima;
    
    public void Push(int valor) {
        Nodo nuevoNodo = new Nodo(valor);
        nuevoNodo.Siguiente = cima;
        cima = nuevoNodo;
    }
    
    public int Pop() {
        if (cima == null) throw new InvalidOperationException("La pila está vacía");
        int valor = cima.Valor;
        cima = cima.Siguiente;
        return valor;
    }
    
    public int Peek() {
        if (cima == null) throw new InvalidOperationException("La pila está vacía");
        return cima.Valor;
    }
    
    public bool IsEmpty() {
        return cima == null;
    }
}
```

### 3. **Lógica de las Torres de Hanoi (TorresDeHanoi.cs)**
Este archivo contiene el **algoritmo recursivo** que resuelve el problema. La función principal `MoverDiscos(int n, Pila origen, Pila destino, Pila auxiliar)` sigue estos pasos:
1. Mueve los `n-1` discos de la torre origen a la torre auxiliar.
2. Mueve el disco restante a la torre destino.
3. Mueve los `n-1` discos desde la torre auxiliar a la torre destino.

Este procedimiento se repite recursivamente hasta que todos los discos se encuentran en la torre destino, respetando las reglas del juego.

Ejemplo de implementación del algoritmo:
```csharp
void MoverDiscos(int n, Pila origen, Pila destino, Pila auxiliar) {
    if (n == 1) {
        Console.WriteLine($"Mover disco de {origen} a {destino}");
        destino.Push(origen.Pop());
    } else {
        MoverDiscos(n - 1, origen, auxiliar, destino);
        MoverDiscos(1, origen, destino, auxiliar);
        MoverDiscos(n - 1, auxiliar, destino, origen);
    }
}
```

## Ejecución del Programa
El programa solicita al usuario que ingrese el número de discos y luego imprime los movimientos necesarios para resolver el problema.

Ejemplo de salida para `n = 3`:
```
Mover disco de A a C
Mover disco de A a B
Mover disco de C a B
Mover disco de A a C
Mover disco de B a A
Mover disco de B a C
Mover disco de A a C
```

## Explicación Paso a Paso del Algoritmo
Si tenemos **3 discos** en la torre de origen `A`, los pasos serían:
1. Mover el disco superior de `A` a `C`.
2. Mover el disco del medio de `A` a `B`.
3. Mover el disco superior de `C` a `B`.
4. Mover el disco más grande de `A` a `C`.
5. Mover el disco superior de `B` a `A`.
6. Mover el disco del medio de `B` a `C`.
7. Mover el disco superior de `A` a `C`.

El mismo patrón se sigue para cualquier número de discos, asegurando que nunca se viole la regla de colocar un disco grande sobre uno más pequeño.

## Requisitos
- Tener instalado **.NET SDK**.
- Compilar el código con `csc TorresDeHanoi.cs`.
- Ejecutar el programa con `dotnet run`.

## Autor
Desarrollado por [LauraGeorginaRuizCampos](https://github.com/LauraGeorginaRuizCampos/Torres-de-Hanoi).


