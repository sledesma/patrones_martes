/**
 * Patrones que implementa:
 * Mediator
 * Facade
 */
class Juego {
	constructor({ personajes }) {

        this._personajes = personajes.map(
            (item) => {
                return {
                    nombre: item,
                    personaje: new Personaje(this, item)
                }
            }
        );

        this._tablero = new Tablero(this);

        console.log(this);
    }
    
	getPersonaje(String_nombre) {
        return this._personajes.find(item => {
            if(item.nombre == String_nombre)
                return true;
        }).personaje;
	}

	/**
	 * Esta función será llamada desde
	 * los distintos componentes. Además de
	 * restar la vida, comprobamos que la vida del
	 * atacado sea menor o igual a 0. Si eso se cumple,
	 * significa que el atacante ganó el juego.
	 *
	 * @param Personaje_atacante - El personaje que ataca
	 * @param Personaje_atacado - El personaje atacado
	 */
	atacar(Personaje_atacante, Personaje_atacado) {
		console.log(Personaje_atacante.nombre, " ataca a ", Personaje_atacado.nombre);
		Personaje_atacado.vida -= 10;

		if (Personaje_atacado.vida <= 0) {
			console.log(Personaje_atacante.nombre, " ganó");
		}
	}
}

class Personaje {
	/**
	 * Para cada componente de la clase mediadora
	 * se necesita una referencia a dicha clase
	 * Esta referencia servirá para comunicar
	 * este componente con la clase mediadora
	 *
	 * @param juego - Referencia a la clase mediadora
	 * */
	constructor(juego, nombre) {
		this.nombre = nombre;
		this.vida = 100;
		this.juego = juego;
	}

	/**
	 * En esta clase componente, se efectuarán
	 * mensajes a la clase mediadora. Por ejemplo,
	 * en vez de atacar directamente, ejecutamos
	 * el método atacar de la clase mediadora.
	 *
	 * @param Personaje_victima - Personaje a atacar
	 */
	atacar(Personaje_victima) {
		this.juego.atacar(this, Personaje_victima);
	}
}

/**
 * La clase Tablero recibe en su constructor
 * la dependencia del Juego. Esto es muy importante
 * ya que los personajes no estan ya dentro de la clase
 * Tablero, sino dentro de la clase Juego. Al sacar
 * el listado de los personajes de la clase Tablero y ponerlos
 * en el mediador, facilitamos el acceso a dicho
 * listado al resto de las partes del juego.
 */
class Tablero {
	constructor(juego) {
		this.juego = juego;
	}

	mostrar() {
		console.log("Mostrando el tablero");
		for (let i = 0; i < this.juego.personajes.length; i++) {
			console.log(this.juego.personajes[i]);
		}
	}
}
