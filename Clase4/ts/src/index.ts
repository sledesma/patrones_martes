function GustoCarne(funcionConstructora: Function) {
    console.log("Aplicando el Decorator Gusto Carne");
    funcionConstructora.prototype.Gusto = "Carne";
}

function PanQuesoCebolla(funcionConstructora: Function) {
    console.log("Aplicando el Decorator Pan Queso y Cebolla");
    funcionConstructora.prototype.Pan = "Queso y cebolla";
}

@GustoCarne
    @PanQuesoCebolla
        class Pedido {
            
            Nombre: string
            
            constructor(nombre: string) {
                this.Nombre = nombre;
            }

        }

const miSanguche:Pedido = new Pedido("Mi Sanguche");

console.log(miSanguche);