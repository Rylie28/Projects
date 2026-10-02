CPP = g++
CPPFLAGS = -std=c++17 -O2 -g -Wall -Wextra -Wpedantic -Wconversion -Wdeprecated -fsanitize=undefined
LDFLAGS =
TEST_LDFLAGS = -lgtest
OBJFILES = main.o socket.o server.o
TEST_OBJFILES = socket.o test_socket.o 
TARGET   = a.out

all: $(TARGET)

$(TARGET): $(OBJFILES)
	$(CPP) $(CPPFLAGS) -o $(TARGET) $(OBJFILES) $(LDFLAGS)

echo:
	$(CPP) $(CPPFLAGS) -o echo echo.cpp

format:
	clang-format --style=file -i *.cpp *.h

sanitize:
	# https://github.com/google/sanitizers/wiki/AddressSanitizer
	clang++ -c socket.cpp -o socket.o
	clang++ -c main.cpp -o main.o
	clang++ $(OBJFILES) -fsanitize=address -O1 -fno-omit-frame-pointer -g -o $(TARGET)
	# clang++ -fsanitize=thread -g

test: $(TEST_OBJFILES) echo
	$(CPP) $(CPPFLAGS) -o test $(TEST_OBJFILES) $(TEST_LDFLAGS)
	@echo
	@echo now in one terminal run ./echo
	@echo and in a second terminal run ./test
	@echo

valgrind: $(TARGET)
	valgrind --tool=memcheck --leak-check=yes --show-reachable=yes --num-callers=20 --track-origins=yes --track-fds=yes ./$(TARGET)

clean:
	rm -f $(TARGET) *.o echo test *~