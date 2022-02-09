# RabbitMQ-Publisher

RabbitMQ for C#
This is a simple guide to RabbitMQ patterns in Linux using C#. The steps on this guide may also be applied to other operating systems but be aware that 
installation and running of RabbitMQ binaries and services could be different. In a nutshell, this guide covers installation, execution and basic 
configuration of the RabbitMQ service in C#.

# Contents
## Getting Started
  1. [Install RabbitMQ](https://www.rabbitmq.com/install-homebrew.html)
  2. Start RabbitMQ Service
```bash
 sudo apt start rabbitmq-services 
```

## Dependencies
  1. Install amqplib for using amqp 
  ```bash
  sudo apt install amqplib
  ```     
## How to run code?
  1. The first run receive.cs
  ```bash
  dotnet src/receive.cs
  ```
  2. Next run send.cs
  ```bash
  dotnet src/send.cs 
  ```
  3. input the massage in sender 
