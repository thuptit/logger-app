using RealPattern.ChainOfResponsibility;

var validation = new ValidatorOrderHandler();
var discount = new DiscountOrderHandler();
var payment = new PaymentOrderHandler();
var ship = new ShippingOrderHandler();

var order = new Order();

validation.NextProcess(discount);
discount.NextProcess(payment);
payment.NextProcess(ship);

validation.Process(order);
