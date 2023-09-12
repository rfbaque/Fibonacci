## SERIE FIBONACCI / API REST CON .NET CORE

*Api Rest que recibe un indice 'N" y retorna el valor de la serie Fibonacci que corresponde al indice obtenido.*


#### Tecnologia Utilizada

- Visual Studio 2022, .Net 6 framework.
- Swagger para la documentacion de la api.

#### Metodos Soportados

- GET : Obtiene el valor de la serie Fibonacci que coincida con un indice recibido por parametro.

#### Ejemplo de request

- GET  **api/v1/fibonacci/{index}**
  *curl --location 'https://localhost:7244/api/v1/fibonacci/10'*

#### Response

- 200 : La informaci&oacute;n ha sido generada satisfactoriamente.
- 400 : Bad request. Error en el par&aacute;metro recibido.

#### Estructura del proyecto
###### Archivos del proyecto

A continuacion se listan los principales archivos del proyecto:

- **Controllers\FibonacciSeries.cs** : Este archivo contiene la accion publica que controla las peticiones HTTP.

- **IFibonacci.cs** : Este archivo contiene el contrato que debe implementar la clase Fibonacci.

- **Fibonacci.cs** : Este archivo contiene la logica que retorna un valor de la serie Fibonacci y contiene las siguientes funciones:
	-	**int[] GetFibonacciSeries(int size)**
		Funcion privada que retorna un arreglo de enteros con la serie fibonacci hasta la posicion que coincida con el 	parametro size.

		    Parametro de Entrada:
				Size: Corresponde al inidice del valor maximo a retornar en la serie fibonacci.
  	 
			Respuesta de funcion:
			 	Retorna un arreglo de enteros con la informacion de la serie Fibonacci hasta el indice que coincida con el valor de size.

	-	**int GetValueOfFibonacciSeries(int index)**
		Funcion publica que retorna el elemento de la serie fibonacci que coincida con el parametro index.
	 	La funcion toma como insumo el resultado de la funcion **GetFibonacciSeries**.

- **Program.cs** : Este archivo contiene las siguientes configuraciones:
  
		- Configuracion de Swagger para la documentacion de la api.
  
		- Se configura un middelware para colocar el archivo de documentacion en la carpeta raiz del proyecto.

  		- Contiene apartado para la configuracion de inyeccion de dependencias por constructor para la clase Fibonacci.

- **bin\debug\.net6.0\FibonacciApi.xml**: Este archivo contiene las configuraciones de Swagger.
  
####  Mejoras en versiones superiores

-	 Incluir accion para autenticacion de apis y agregar autorizacion sobre la api.
-	 incluir configuracion de Rate Limit para proteger a la api contra ataques de denegacion de servicios.
-	 Incluir modulo de logs.
-	 Incluir Cacheo de respuestas.
-	 Mapear las salidas para customizar la informacion a mostrar al usuario, por ejemplo: Retornar la informacion de la serie Fibonacci hasta el limite del parametro size.

