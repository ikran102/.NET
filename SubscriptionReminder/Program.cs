using System;

class SubscriptionReminder
{
    static void Main()
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        // Calculate discount based on days until expiration
        if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
        }
        else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
        {
            discountPercentage = 10;
        }

        // Check subscription status and provide appropriate messages
        if (daysUntilExpiration < 1)
        {
            Console.WriteLine("Your subscription has expired!");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
        else
        {
            Console.WriteLine($"Your subscription is valid for another {daysUntilExpiration} days.");
            Console.WriteLine("Consider renewing early for additional benefits!");
        }

        // Additional feature: Early renewal message
        if (daysUntilExpiration > 5)
        {
            Console.WriteLine("Early Renewal Offer: Renew now and get a 5% discount!");
        }
    }
}

