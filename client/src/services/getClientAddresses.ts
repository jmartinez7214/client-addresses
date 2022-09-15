import { basePath, apiVersion } from "./config";
import { Address } from "../types";

export const getClientAddresses = (id: number): Promise<Address[]> => {
  const url = `${basePath}/${apiVersion}/client/address/${id}`;

  return fetch(url)
    .then((res) => res.json())
    .then((data) => data)
    .catch((err) => err);
};
