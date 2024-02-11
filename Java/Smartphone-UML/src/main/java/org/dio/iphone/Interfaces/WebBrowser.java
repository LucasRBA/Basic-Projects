package org.dio.iphone.Interfaces;

public interface WebBrowser {

    public default void displayPage(String url){
        System.out.println("Loading page ".concat(url).concat("."));
    }

    public default void displayPageFullscreen(String url){
        System.out.println("Entering fullscreen mode on page ".concat(url).concat("..."));
    }

    public default void addNewTab(){
        System.out.println("New tab opened");
    }

    public default void refreshpage(){
    }

    public default void searchOnGoogle(String query){
    }
}
