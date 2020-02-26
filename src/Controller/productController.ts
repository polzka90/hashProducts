import { Request, Response } from "express";

import { Product } from '../Models/Product';

export let index = (req: Request, res: Response) => {
    let languages = [
        {
            language: 'Spanish'
        },
        {
            language: "French"
        },
        {
            langauge: "German"
        }
    ];
    res.json(languages);
};


export let create = (req: Request, res: Response) => {
    let prod : Product = {
        Id : req.body.id,
        PriceInCents : req.body.price_in_cents,
        Title : req.body.title,
        Description : req.body.descripcion,
        Discount : req.body.discount
    };


    res.json(prod);
};