import { useEffect, useState } from "react";
import { Client } from "../types";
import { notification } from "antd";
import { getAllClients } from "../services/getAllClients";

const useClients = () => {
  const [clients, setClients] = useState<Client[]>([]);

  useEffect(() => {
    getAllClients()
      .then(setClients)
      .catch(() => {
        notification["error"]({
          message: "Server error, try later.",
        });
      });
  }, []);

  return {
    clients,
  };
};

export default useClients;
