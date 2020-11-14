# BehavioralPatterns.Strategy

**Arquitectura de Software - Laboratorio 4**

**Problema:** Una app de navegacion es capaz de buscar la mejor ruta para llegar de un origen a un destino definido por el usuario. Sin embargo, la primera version solo
contempla rutas para carros. Se quieren añadir las rutas para bicis y para ir caminando. Por tanto, se tendrian que añadir nuevos algoritmos para la busqueda de estas nuevas rutas.

Cada vez que se quiera añadir nuevos algoritmos de busqueda de ruta se tendria que modificar el código principal de la app, haciendo que este se vuelva cada vez mas grande y dificil de mantener.

**Solución:** Con el patron Strategy podemos separar en clases diferentes cada algoritmo de busqueda de ruta que se quiera implementar. Asi, cada vez que se quiera utilizar un algoritmo distinto solo se debe crear una instancia de la clase correspondiente,
sin necesidad de modificar en gran manera el código principal de la app, el cual se comportaria del mismo modo independientemente de que algoritmo de busqueda de ruta se utilice.
