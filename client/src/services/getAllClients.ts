import { basePath, apiVersion } from "./config";
import { Client } from "../types";

export const getAllClients = (): Promise<Client[]> => {
  const url = `${basePath}/${apiVersion}/Client`;

  return fetch(url)
    .then((res) => res.json())
    .then((data) => data)
    .catch((err) => err);
};
