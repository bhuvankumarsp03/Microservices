// without Dependency Injection
// class Engine{

// }

// class Tyre{

// }

// class Car{
//     engine: Engine;
//     tyre: Tyre;

//     constructor(){
//         this.engine = new Engine();
//         this.tyre = new Tyre();
//     }
// }




// with dependency injection
class Engine{
    constructor(type: string){

    }
}

class Tyre{
    constructor(type: string){

    }
}

const engineObj = new Engine();
const tyreObj = new Tyre();


class Car{
    engine: Engine;
    tyre: Tyre;

    constructor(engineObj: Engine, tyreObj: Tyre){
        this.engine = engineObj;
        this.tyre = tyreObj;
    }
}
