class QueueUsingArray{

    public int front,rear ,capacity;
    public int [] queue;

    public QueueUsingArray(int c)
    {
        rear =front = 0;
        this.capacity = c;
        queue = new int[capacity];
    }

    public void QueueEnQueue(int data)
    {
        if(capacity == rear)
        {
            System.out.println("Queue is Empty");
            return;
        }
        else {

            queue[rear] = data;
            rear++;
        }
        return;
    }

    public void QueueDeQueue()
    {
        if(front == rear)
        {
            System.out.print("Queue is Empty");
            return;
        }
        else {

            for (int i  = 0; i <rear-1;i++)
            {
                queue[i] = queue[i+1];
            }

            if (rear <capacity)
                queue[rear] = 0;

            rear--;
        }

        return;
    }


    public void QueueDisplay()
    {
        if (front == rear)
        {
            System.out.println("Queu is Empty");
            return;
        }

        for (int i =front; i<rear; i++) {
            System.out.println("< --" + queue[i]);
        }

    }


    public void QueueFront() {

        if (front == rear) {
            System.out.println("Queu is Empty");
            return;
        }

        System.out.println("Front Element is " + queue[front]);

        return;
    }
}




public class Main {

    public static void main(String[] args) {

        QueueUsingArray queue = new QueueUsingArray(5);
        System.out.println("Hello World!");
        queue.QueueEnQueue(25);
        queue.QueueEnQueue(35);
        queue.QueueEnQueue(45);
        queue.QueueEnQueue(55);
        queue.QueueEnQueue(65);
        queue.QueueDisplay();
        queue.QueueDeQueue();
        queue.QueueDisplay();
        queue.QueueDeQueue();
        queue.QueueDisplay();

        queue.QueueFront();
    }
}
