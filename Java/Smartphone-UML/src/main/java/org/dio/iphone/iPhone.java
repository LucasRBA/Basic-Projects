package org.dio.iphone;

import org.dio.iphone.Entities.Smartphone;
import org.dio.iphone.Interfaces.MusicPlayer;
import org.dio.iphone.Interfaces.Telephone;
import org.dio.iphone.Interfaces.WebBrowser;

public class iPhone extends Smartphone {

    private String model;

    private Integer year;

    MusicPlayer iTunes = new MusicPlayer(){
        @Override
        public void play(){
            System.out.println("Playing songs in random mode");
        };

        @Override
        public void pause() {
            System.out.println("Song paused");
        }

        @Override
        public void selectMusic() {
            System.out.println("Playing selected Song");
        }
    };

    Telephone cellphone = new Telephone(){

        @Override
        public void call(Long phoneNumber){
            System.out.println("Calling ".concat( String.valueOf(phoneNumber)
                    .replaceFirst("(\\d{3})(\\d{3})(\\d{4})","($1)-$2-$3")));
        }
        @Override
        public void acceptCall(){
            System.out.println("Connecting...");
        }

        @Override
        public void declineCall(){
            System.out.println("Call declined...");
        }

        @Override
        public void sendVoiceMessage(){
            System.out.println("Sending voice message...");
        }

        @Override
        public void sendSMS(){
            System.out.println("Sending message...");
        }
    };

    WebBrowser safari = new WebBrowser(){
        private String query;

        public void searchOnGoogle(String query) {
            this.query = query;
            System.out.println("About ".concat(String.valueOf(Math.random()*1000000)).concat(" results found for ")
                    .concat(query).concat("."));
        }

        public String getQuery() {
            return query;
        }

        public void setQuery(String query) {
            this.query = query;
        }
    };


    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public Integer getYear() {
        return year;
    }

    public void setYear(Integer year) {
        this.year = year;
    }

    @Override
    public String toString() {
        return "iPhone{" +
                "model='" + model + '\'' +
                ", year=" + year +
                '}';
    }
}
