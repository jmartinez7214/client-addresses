import { basePath, apiVersion } from "./config";
import { Client } from "../types";

export const getClient = (id: number): Promise<Client> => {
  const url = `${basePath}/${apiVersion}/client/${id}`;

  return fetch(url)
    .then((res) => res.json())
    .then((data) => data)
    .catch((err) => err);
};
