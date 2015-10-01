# WCF-AsyncTask-example
WCF + Client WPF with loaded animation example + Implement AsyncTask method


Ejemplo sencillo de un cliente WPF que hace una llamada asíncrona a un servicio, espera la respuesta liberando la UI, 
en ese intervalo de 10 seg se puede interactuar con el resto de la UI, por ejemplo, el boton de refresh que actualiza los
datos con valores locales, hasta que llegan los valores del servicio.


Adicionalmente está definido un UserControl de un Loading, con dos métodos uno de Start y otro de Stop, para poderlo lanzar 
en cualquier momento
