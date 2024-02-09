package org.dio;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.function.Executable;

import org.dio.exceptions.InvalidParameterException;

import static org.junit.jupiter.api.Assertions.*;

import java.io.ByteArrayInputStream;
import java.io.InputStream;

class CounterTest {

    Counter counter = new Counter();

    private final InputStream originInputStream = System.in;

    void setUp() {
        Counter counter = new Counter();
    }

    @Test
    void testCount_validInputs() throws InvalidParameterException {

        String input = "5\n10\n";
        InputStream inputStream = new ByteArrayInputStream(input.getBytes());
        System.setIn(inputStream);

        // Assert count() does not throw exception
        Assertions.assertDoesNotThrow(()-> counter.count());
    
    }

    @Test
    void testCount_invalidInputs() {
    
        counter.setFirstNumber(5); 
        counter.setSecondNumber(1);

        assertThrows(InvalidParameterException.class, () -> counter.count());
    }

    @Test
    void testValidate_valid() {
        Counter counter = new Counter();
        try {
            boolean result = counter.validate(1, 5);
            assertTrue(result);
        } catch (Exception e) {
            System.out.println("Invalid Numbers");
        }

    }

    @Test
    void testValidate_invalid() {
        Counter counter = new Counter();

        assertThrows(InvalidParameterException.class, () -> {
            counter.validate(5, 1);
        });
    }

    @Test
    void testSetFirstNumber() {
        Counter counter = new Counter();
        Integer testValue = 5;

        counter.setFirstNumber(testValue);

        assertEquals(testValue, counter.getFirstNumber());
    }

    @Test 
    void testSetSecondNumber() {
        Counter counter = new Counter();
        Integer testValue = 10;

        counter.setSecondNumber(testValue);

        assertEquals(testValue, counter.getSecondNumber());
    }

    @AfterEach
    void tearDown() {
        System.setIn(originInputStream);
    }
}