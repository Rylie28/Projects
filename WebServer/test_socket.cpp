#include "socket.h"
#include "gtest/gtest.h"
#include <vector>

class SocketTest : public testing::Test
{

  protected:
    Socket s;
    std::string message = "Hello, world";
    std::vector<unsigned char> data = {0x00, 0x01, 0x02, 0x03,
                                       0x04, 0x05, 0x06, 0x07};

    SocketTest() : s()
    {
        // You can do set-up work for each test here.
        s.connect();
    }

    ~SocketTest() override
    {
        // You can do clean-up work that doesn't throw exceptions here.
        // s.close();
        s.close();
    }

    // If the constructor and destructor are not enough for setting up
    // and cleaning up each test, you can define the following methods:

    void SetUp() override
    {
        // Code here will be called immediately after the constructor (right
        // before each test).
    }

    void TearDown() override
    {
        // Code here will be called immediately after each test (right
        // before the destructor).
    }

    // Class members declared here can be used by all tests in the test suite
};

TEST_F(SocketTest, SendData) { EXPECT_EQ(s.send(data), data.size()); }

TEST_F(SocketTest, Send)
{
    std::vector<unsigned char> payload(message.begin(), message.end());

    EXPECT_EQ(s.send(payload), message.length());
}

TEST_F(SocketTest, RecvData)
{
    s.send(data);
    std::vector<unsigned char> buffer(512);
    EXPECT_EQ(s.recv(buffer), data.size());
}

TEST_F(SocketTest, Recv)
{
    std::vector<unsigned char> payload(message.begin(), message.end());
    s.send(payload);
    std::vector<unsigned char> buffer(512);
    EXPECT_EQ(s.recv(buffer), message.length());
}

int main(int argc, char** argv)
{
    ::testing::InitGoogleTest(&argc, argv);
    return RUN_ALL_TESTS();
}
