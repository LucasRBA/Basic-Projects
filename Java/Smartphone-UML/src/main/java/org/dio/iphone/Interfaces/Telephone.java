package org.dio.iphone.Interfaces;

public interface Telephone {


    public default void call(Long phoneNumber){
    }

    public default void acceptCall(){
    }

    public default void declineCall(){
    }

    public default void sendVoiceMessage(){
    }

    public default void sendSMS(){
    }

}
