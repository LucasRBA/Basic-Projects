package org.dio.iphone.Entities;

import org.dio.iphone.Interfaces.MusicPlayer;
import org.dio.iphone.Interfaces.Telephone;
import org.dio.iphone.Interfaces.WebBrowser;

public class Smartphone implements MusicPlayer, Telephone, WebBrowser{

    private boolean state;

    public void switchOn(){
        System.out.println("Switching the device on, please wait...");
        this.setState(true);
    }

    public void switchOff(){
        System.out.println("Switching off the device, please wait...");
        this.setState(false);
    }

    public boolean getState() {
        return state;
    }

    public void setState(boolean state) {
        this.state = state;
        if(state)
            System.out.println("Device finished booting up!");
        else
            System.out.println("Device is switching off...");
    }

}
