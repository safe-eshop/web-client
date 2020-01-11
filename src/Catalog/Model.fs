module Model 

type ProductDetails = {
    weight: int;
    weightUnits: string;
    manufacturer: string;
    color: string;
}

type PictureUrl = string
type Price = int
type ProductId = string

type ProductInfo = {
    name: string;
    slug: string;
    rand: string;
    description: string
    picture: PictureUrl
}

type Product = {
    id: ProductId;
    info: ProductInfo;
    details: ProductDetails;
    price: Price;
}