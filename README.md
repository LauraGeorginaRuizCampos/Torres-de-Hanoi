# Torres-de-Hanoi

El programa utiliza una estructura de datos de pila para simular las varillas y los discos. A continuación, se describe brevemente cada componente:

    Nodos (Nodos.cs): Define la estructura básica de un nodo, que representa un disco en la pila. Cada nodo contiene un valor (tamaño del disco) y una referencia al siguiente nodo en la pila.

    Pilas (pilas.cs): Implementa la estructura de datos de pila utilizando los nodos. Proporciona métodos para apilar (push), desapilar (pop) y verificar el disco en la cima de la pila (peek).

    Lógica de las Torres de Hanoi (Torres de hanoi.cs): Contiene el algoritmo recursivo que resuelve el problema. La función principal MoverDiscos sigue estos pasos:
        Mueve n-1 discos de la varilla origen a la varilla auxiliar.
        Mueve el disco restante de la varilla origen a la varilla destino.
        Mueve los n-1 discos de la varilla auxiliar a la varilla destino.

    Este enfoque recursivo garantiza que se sigan las reglas del juego y que todos los discos se muevan correctamente a la varilla destino.

    El programa de Torres de Hanoi implementa un algoritmo recursivo para resolver el problema. Primero, solicita al usuario el número de discos con los que desea jugar. Luego, inicia la solución siguiendo la lógica del problema: mover los discos de una torre de origen a una torre de destino, utilizando una torre auxiliar.

El código define una función principal que sigue estos pasos:

    Si hay un solo disco, se mueve directamente de la torre de origen a la torre de destino.
    Si hay más de un disco, primero se mueve la pila superior (excepto el disco más grande) a la torre auxiliar.
    Luego, el disco más grande se mueve a la torre de destino.
    Finalmente, la pila que estaba en la torre auxiliar se mueve a la torre de destino sobre el disco más grande.

Este proceso se repite recursivamente hasta que todos los discos estén en la torre de destino, respetando las reglas del juego.

El programa imprime cada uno de los movimientos necesarios para completar la solución, permitiendo visualizar cómo se trasladan los discos de una torre a otra.
