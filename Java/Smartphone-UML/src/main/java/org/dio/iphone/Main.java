package org.dio.iphone;



public class Main {
    public static void main(String[] args) {

        iPhone iphone = new iPhone();

        iphone.switchOn();

        iphone.getState();

        iphone.setYear(2022);

        iphone.setModel("13 Pro Max");

        iphone.toString();

        iphone.iTunes.play();

        iphone.iTunes.pause();

        iphone.iTunes.selectMusic();

        iphone.cellphone.call(5146387469L);

        iphone.safari.displayPage("thetimes.com");

        iphone.safari.displayPageFullscreen("youtube.com");

        iphone.cellphone.declineCall();

        iphone.addNewTab();

        iphone.safari.searchOnGoogle("Java vs Rust ");

        iphone.cellphone.acceptCall();


    }
}