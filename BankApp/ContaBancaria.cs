
using System;

using System.Collections.Generic;

namespace ConsoleApp1;

class Equipe{
    private List<string> carros;

    private List<Piloto> pilotos;

    public void Contract(Piloto pilotos){
        this.pilotos.Add(pilotos);
    }

    public void Fire(Piloto pilotos){
        foreach(var item in this.pilotos){
            if(item == pilotos){
                this.pilotos.Remove(item);
            }
        }
    }

    public void Fire(string nome){
        foreach(var item in this.pilotos){
            if(item.nome == nome){
                this.pilotos.Remove(item);
            }
        }
    }

}