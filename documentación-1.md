---
title: "Documentación 1"
tags: ""
---
# Proyecto MacMapkerson

## Análisis de la solución

### Patrones empleados

Para la implementación del sistema dado en el enunciado, he usado los siguientes patrones:

-   He usado una **_Simple Factory_** para crear el ejército
-   He usado un **_Builder_** para crear los diferentes componentes(unidades)
-   **_Iterator_** en el método que calcula los datos(en UtilidadesEjercito/Algoritmos)
-   Patrón **_Decorator_** para cada uno de los componentes de ejército.
-   Por último, he usado varios patrones **_Flag_** para identificar los tipos de componentes.

![Diagrama de clases](\WindowsFormsApp4\DiagramaClase.jpg)
