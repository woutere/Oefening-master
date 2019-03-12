/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oefening;

/**
 *
 * @author c1042450
 */
public class Lamp {
    private String merk;
    private int vermogen;
    
    public String getMerk(){
        return merk;
    }
    public int getVermogen(){
        return vermogen;
    }
    
    public void setMerk(String merk){
        this.merk=merk;
    }
    public void setVermogen(int vermogen){
        this.vermogen=vermogen;
    }
    public String toString(){
        return "Kenmerken van de lamp: " + merk.toUpperCase() + " - "+ vermogen + " Watt";
    }
}
