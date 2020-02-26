import * as myConfig from './config.json';
import * as express from "express";

import * as productController from "./controller/productController";

const server = express();
const port = myConfig.myServerInfo.port; // default port to listen

server.get('/product', productController.index);
server.post('/product/create', productController.create);

server.listen(port);